using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class RegisterForm : Form
    {

        

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            UserServiceReference.IUserService _userService = new Client.UserServiceReference.UserServiceClient();
            string userName = userNameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string mobileNo = mobileNoTextBox.Text;

            string msg = Convert.ToString(_userService.register(userName, email, password, mobileNo));
            MessageBox.Show(msg);
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Switch to the login form
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            //Close();
        }
    }
}
