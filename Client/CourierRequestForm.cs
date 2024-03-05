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
    public partial class CourierRequestForm : Form
    {
        public CourierRequestForm()
        {
            InitializeComponent();
        }

        private void CourierRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Process the form submission, e.g., send data to a database or API
                int sender_id = Convert.ToInt32(textBoxSenderID.Text);
                string sender_address = textBoxSenderAddress.Text;
                string src_city = textBoxSourceCity.Text;
                string receiver_name = textBoxReceiverName.Text;
                string receiver_address = textBoxReceiverAddress.Text;
                string receiver_mobile = textBoxReceiverMobile.Text;
                string dest_city = textBoxDestinationCity.Text;

                CourierServiceReference.CourierServiceClient serviceClient = new CourierServiceReference.CourierServiceClient();
                int courier_id = Convert.ToInt32(serviceClient.placerequest(sender_id, sender_address, src_city, receiver_name, receiver_address, receiver_mobile, dest_city));
                MessageBox.Show("Courier Request Placed. Courier ID : " + courier_id + " Please Note the Courier ID.");
                //ClearForm();
                Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields correctly.");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(textBoxSenderID.Text) ||
                string.IsNullOrEmpty(textBoxSenderAddress.Text) ||
                string.IsNullOrEmpty(textBoxSourceCity.Text) ||
                string.IsNullOrEmpty(textBoxReceiverName.Text) ||
                string.IsNullOrEmpty(textBoxReceiverAddress.Text) ||
                string.IsNullOrEmpty(textBoxReceiverMobile.Text) ||
                string.IsNullOrEmpty(textBoxDestinationCity.Text))
            {
                return false;
            }

            // Additional validation logic can be added here

            return true;
        }

        private void ClearForm()
        {
            textBoxSenderID.Text = "";
            textBoxSenderAddress.Text = "";
            textBoxSourceCity.Text = "";
            textBoxReceiverName.Text = "";
            textBoxReceiverAddress.Text = "";
            textBoxReceiverMobile.Text = "";
            textBoxDestinationCity.Text = "";
        }
    }
}
