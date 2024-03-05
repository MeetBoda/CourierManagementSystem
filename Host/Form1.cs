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
        ServiceHost sh = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri tcpa = new Uri("net.tcp://localhost:8010/Design_Time_Addresses/CourierManagementSystem/UserService/mex");
            Uri http = new Uri("http://localhost:8733/Design_Time_Addresses/CourierManagementSystem/");
            sh = new ServiceHost(typeof(Service1), tcpa);

            NetTcpBinding tcpb = new NetTcpBinding();

            ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();
            sh.Description.Behaviors.Add(mBehave);
            sh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
            sh.AddServiceEndpoint(typeof(IService1), tcpb, tcpa);

            sh.Open();
            label1.Text = "Service Running ...";
        }
    }
}
