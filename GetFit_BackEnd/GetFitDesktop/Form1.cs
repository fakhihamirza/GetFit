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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Username.Text.ToString().Trim() != "" && pass.Text.ToString().Trim() != "")
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:38476");
                    Login_user lgn = new Login_user { UserName = username_txt.Text.ToString(), password = pass.Text.ToString() };
                    var response = client.PostAsJsonAsync("/api/login", lgn).Result;
                    var a = response.Content.ReadAsStringAsync();
                    if (a.Result.ToString().Trim() == "0")
                    {
                        MessageBox.Show("Invalid Login credentials");
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Logged In Successful");
                        Profile p = new Profile();
                        this.Hide();
                        p.Show();
                    }
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}