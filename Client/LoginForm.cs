using Client.UserServiceReference;
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

    public static class LoginInfo
    {
        public static int UserID;
        public static string UserName;
    }

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

            UserInfo userinfo = _userService.login(email, password);
            if(userinfo.message == "Admin Login")
            {
                LoginInfo.UserID = Convert.ToInt32(userinfo.UserID);
                LoginInfo.UserName = userinfo.UserName;
                AdminHomeScreenForm adminHomeScreenForm = new AdminHomeScreenForm();
                adminHomeScreenForm.ShowDialog();
                Close();
            }
            else if(userinfo.message == "Login Successful")
            {
                LoginInfo.UserID = Convert.ToInt32(userinfo.UserID);
                LoginInfo.UserName = userinfo.UserName;
                //MessageBox.Show(userinfo.message);
                HomeScreenForm homeScreenForm = new HomeScreenForm();
                homeScreenForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(userinfo.message);
            }
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
