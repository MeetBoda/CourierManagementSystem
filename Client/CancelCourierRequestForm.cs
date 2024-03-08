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
    public partial class CancelCourierRequestForm : Form
    {
        public CancelCourierRequestForm()
        {
            InitializeComponent();
        }

        private void CancelCourierRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            CourierServiceReference.CourierServiceClient serviceClient = new CourierServiceReference.CourierServiceClient();
            int courierNumber = Convert.ToInt32(courierNumberTextBox.Text);
            // Use the courierNumber value for further processing
            string message = serviceClient.cancelrequest(courierNumber, LoginInfo.UserID);
            MessageBox.Show(message);
            this.Close();
        }
    }
}
