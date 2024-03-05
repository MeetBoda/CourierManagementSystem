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
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void placeRequestButton_Click(object sender, EventArgs e)
        {
            CourierRequestForm courierRequestForm = new CourierRequestForm();
            courierRequestForm.ShowDialog();
            //Close();
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(2);
            profileForm.ShowDialog();
        }

        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
            //Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            
        }

        private void cancelRequestButton_Click(object sender, EventArgs e)
        {
            CancelCourierRequestForm cancelCourierRequestForm = new CancelCourierRequestForm();
            cancelCourierRequestForm.ShowDialog();
            //Close();
        }
    }
}
