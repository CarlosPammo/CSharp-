using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Controller;
using WindowsForms.Model;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public LoginController Controller { get; set; }
        public Form1()
        {
            InitializeComponent();
            Controller = new LoginController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Login = textLogin.Text,
                Password = textPassword.Text
            };

            if (textLogin.Text == "")
            {
                throw new Exception("The login is empty");
            }
            if (user == null)
            {
                throw new Exception("User is null");
            }

            bool isValid = Controller.IsAvailable(user);
            MessageBox.Show(isValid ? "User authenticated" : "Not valid user");
        }
    }
}
