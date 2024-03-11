using CourierManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    public partial class Form1 : Form
    {
        //ServiceHost sh = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceHost sh1 = new ServiceHost(typeof(CourierManagementSystem.UserService));
            ServiceHost sh2 = new ServiceHost(typeof(CourierManagementSystem.AdminService));
            ServiceHost sh3 = new ServiceHost(typeof(CourierManagementSystem.CourierService));
            ServiceHost sh4 = new ServiceHost(typeof(CourierManagementSystem.ProfileService));
            sh1.Open();
            sh2.Open();
            sh3.Open();
            sh4.Open();
            label1.Text = "Service Running ...";
        }
    }
}
