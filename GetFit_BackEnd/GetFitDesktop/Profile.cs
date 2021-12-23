using GetFitApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFitDesktop
{
    public partial class Profile : Form
    {
        public async Task<Getdata> Get_Api_Data(string query)
        {
            Getdata dat = new Getdata();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.calorieninjas.com/v1/nutrition?query=");
                var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get, "https://api.calorieninjas.com/v1/nutrition?query=" + query)
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
                    MessageBox.Show(dat.items.ToString());
                    return dat;
                }
                else //web api sent error response 
                {
                    MessageBox.Show(string.Empty, "Server error. Please contact administrator.");
                    return dat;
                }
            }
        }
        public Profile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Get_Api_Data(query.Text);
            //Getdata dat = JsonConvert.DeserializeObject<Getdata>(result.ToString());
            //GGMessageBox.Show(dat.items.ToString());
            //MessageBox.Show();


        }
    }
}
