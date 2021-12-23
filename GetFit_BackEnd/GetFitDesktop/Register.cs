using DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFitDesktop
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Register1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:38476");
                Register_user lgn = new Register_user { UserName = uname.Text.ToString(), password = pass.Text.ToString(), FirstName=fname.Text.ToString(), LastName=Lname.Text.ToString() };
                var response = client.PostAsJsonAsync("/api/register", lgn).Result;
                var a = response.Content.ReadAsStringAsync();
                if (a.Result.ToString().Trim() == "0")
                {
                    MessageBox.Show("UserName Already exists");
                }
                else
                {
                    MessageBox.Show("Successfully Registered!");
                    Profile p = new Profile();
                    this.Hide();
                    p.Show();
                }
            }

            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
