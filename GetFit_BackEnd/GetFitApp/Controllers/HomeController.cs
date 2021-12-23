using GetFitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace GetFitApp.Controllers
{
    public class Tokenclass
    {
        public string Token { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configure;
        private readonly string Api_Base_Url;

        // Dependency Injection  for using api url
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configure = configuration;

            Api_Base_Url = _configure.GetValue<string>("GetFitApiUrl");
        }
        //redirection Page   


        [HttpPost]
        public async Task<ActionResult> Profile(Get_user user)
        {
            Console.WriteLine("Inside post profile");
            Console.WriteLine(user.query);
            return RedirectToAction("GetData", "Home", user);
        }

        [HttpGet]
        public async Task<ActionResult> Profile(int id)
        {
            Console.WriteLine("Profile ka action");
            Console.WriteLine(id); //5
            Get_user user = new Get_user();

             using (var client = new HttpClient())
             {
                client.BaseAddress = new Uri(Api_Base_Url);
                HttpResponseMessage result = await client.GetAsync($"api/user/{id}");
                Console.WriteLine(result);
                if (result.IsSuccessStatusCode)
                {
                    var res = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(res);
                    user = JsonConvert.DeserializeObject<Get_user>(res);
                    Console.WriteLine("hehehehe");
                    Console.WriteLine(user);
                }
                else //web api sent error response 
             {
                    ModelState.Clear();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }
        }
            return View(user);
            //return RedirectToAction("GetData", "Home", new { User = user });
        }

        [HttpGet]
        public async Task<IActionResult> GetData(Get_user userq)
        {
            Console.WriteLine("Get Data k ander");
            Console.WriteLine(userq.query);
            Getdata dat = new Getdata();
            ViewProfileModel mymodel = new ViewProfileModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.calorieninjas.com/v1/nutrition?query=");
                var httpRequestMessage = new HttpRequestMessage(
                    HttpMethod.Get, "https://api.calorieninjas.com/v1/nutrition?query=" + userq.query)
                {
                    Headers =
                    {
                        {"X-Api-Key", "AO13EqujXZSew1GG91sb+w==HxYGA1UCIqw9m37c"}
                    }
                };
                client.DefaultRequestHeaders.Add("X-Api-Key", "AO13EqujXZSew1GG91sb+w==HxYGA1UCIqw9m37c");
                HttpResponseMessage result = await client.SendAsync(httpRequestMessage);
                Console.WriteLine(result);
                if (result.IsSuccessStatusCode)
                {
                    var res = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(res);
                    dat = JsonConvert.DeserializeObject<Getdata>(res);
                    Console.WriteLine("hahahaha in data");
                    Console.WriteLine(dat);
                    using (HttpClient client1 = new HttpClient())
                    {
                        WriteHistory obj = new WriteHistory();
                        foreach (var i in dat.items)
                        {
                            obj.UserID = userq.UserID;
                            obj.food_name = i.name;
                        }
                        StringContent content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                        string endpoint = Api_Base_Url + "/api/addresult";
                        using (var Response = await client.PostAsync(endpoint, content))
                        {
                            if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                var res1 = await Response.Content.ReadAsStringAsync();
                                Console.WriteLine(res1);
                            }
                        }
                    }
                }
                else //web api sent error response 
                {
                    ModelState.Clear();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
                }
                mymodel.gt = dat;
                mymodel.gu = userq;
                return View(mymodel);
            }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            Register_user user = new Register_user();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register_user user)
        {
            //List<UserInfo> list = new List<UserInfo>();
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                string endpoint = Api_Base_Url + "/api/register";
                using (var Response = await client.PostAsync(endpoint, content))
                {
                    if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var res = await Response.Content.ReadAsStringAsync();
                        Console.WriteLine(res);
                        var id = JsonConvert.DeserializeObject<int>(res);
                        Console.WriteLine(id);
                        //Response.Headers.Location
                        //TempData["Profile"] = JsonConvert.SerializeObject(user);
                        //return RedirectToAction("Profile");
                        return RedirectToAction("Profile", "Home", new {  id });
                    }
                    else if (Response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        ModelState.Clear();
                        ModelState.AddModelError("Username", "Username Already Exist");
                        return View();
                    }
                    else
                    {
                        return View();
                    }
                }

            }
        }

        // Method to authenticate user login   
        [HttpGet]
        public ActionResult Login()
        {
            Login_user user = new Login_user();
            return View(user);
        }


        [HttpGet]
        public async Task<ActionResult> History(int id)
        {
            //List<ReadHistory> user = new List<ReadHistory>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Api_Base_Url);
                Console.WriteLine(Api_Base_Url);
                HttpResponseMessage result = await client.GetAsync($"api/UserHistory/{id}");
                Console.WriteLine(result);
                if (result.IsSuccessStatusCode)
                {
                    var res = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(res);
                    var user = JsonConvert.DeserializeObject<IEnumerable<ReadHistory>>(res);
                    Console.WriteLine("hehehehe");
                    Console.WriteLine(user);
                    user.ToList();
                    Console.WriteLine(user);
                    return View(user);
                }
                else //web api sent error response 
                {
                    ModelState.Clear();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View();
        }




        [HttpPost]
        public async Task<ActionResult> Login(Login_user user)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                string endpoint = Api_Base_Url + "/api/login";
                Console.WriteLine("Login " + Api_Base_Url);
                using (var Response = await client.PostAsync(endpoint, content))
                {
                    var jsonString = await Response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Tokenclass>(jsonString);
                    if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine("Inside Login ka if");
                        Console.WriteLine(result.Token);
                        var handler = new JwtSecurityTokenHandler();
                        var x = handler.ReadJwtToken(result.Token);
                        var user_id = x.Claims.First(claim => claim.Type == "UserID").Value; //5
                        var temp_id = Convert.ToInt32(user_id);
                        Console.WriteLine("After id convert");
                        Console.WriteLine(temp_id);
                        return RedirectToAction("Profile", "Home", new { id = temp_id });
                    }
                    else
                    {
                        ModelState.Clear();
                        ModelState.AddModelError(string.Empty, "Username or Password is Incorrect");
                        return View();
                    }
                }
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


