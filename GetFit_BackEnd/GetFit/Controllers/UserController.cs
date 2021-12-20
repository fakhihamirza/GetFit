using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.DTO;
using GetFit.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using GetFit.Providers;

namespace GetFit.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api/user hoga route if controller name is user
    public class UserController : ControllerBase
    {
        private UserContract user_contract;
        private readonly IMapper _Mapper;
        public UserController(UserContract obj, IMapper Mapper)
        {
            user_contract = obj;
            _Mapper = Mapper;
        }

        [HttpGet("{id}", Name = "GetUser")] //append to base level route
        public ActionResult<Get_User> GetUser(int Id)   //given an if return Get_user ka user obj
        {
            var user_obj = user_contract.GetUser(Id);  //contract wala getuser
            if (user_obj != null)
            {
                return Ok(_Mapper.Map<Get_User>(user_obj));
            }
            else
            {
                return NotFound();
            }
        }

        [AllowAnonymous]
        [Route("~/api/register")] // localhost:port/api/register
        [HttpPost]
        public ActionResult<User> Register(Register_user External_user_obj)   
        {
            string Hashed_Password = BCrypt.Net.BCrypt.HashPassword(External_user_obj.password);
            External_user_obj.password = Hashed_Password;
            var New_User = (User)_Mapper.Map<User>(External_user_obj); // map Ext_user_obj to user obj(internal)
            user_contract.CreateUser(New_User);
            user_contract.SaveChanges();
            var Read_User = _Mapper.Map<Get_User>(New_User);
            //return Ok(_Mapper.Map<User>(Read_User));
            return CreatedAtRoute(nameof(GetUser), new { Id = New_User.UserID }, Read_User);
        }
        [Route("~/api/login")]
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(Login_user is_user)
        {
            dynamic Token_Object = new ExpandoObject();
            Token_Object.Token = user_contract.LoginUser(is_user);
            if (Token_Object.Token == null)
            {
                return Unauthorized();
            }
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(Token_Object));
            // conversion to json object
        }
    }

}
