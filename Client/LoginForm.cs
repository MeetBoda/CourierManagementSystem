using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserServiceReference.IUserService _userService = new Client.UserServiceReference.UserServiceClient();
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            string msg = Convert.ToString(_userService.login(email, password));
            
            MessageBox.Show(msg);
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Switch to the registration form
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            Close();
        }
    }
}
