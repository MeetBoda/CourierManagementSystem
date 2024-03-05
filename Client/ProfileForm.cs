using Client.ProfileServiceReference;
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
    public partial class ProfileForm : Form
    {
        public ProfileForm(int user_id)
        {
            InitializeComponent();
            ProfileServiceReference.ProfileServiceClient profileService = new ProfileServiceReference.ProfileServiceClient();
            Profile profile = profileService.getData(user_id);
            nameLabel.Text = "Name: " + profile.user_name;
            emailLabel.Text = "Email: " + profile.email;
            mobileLabel.Text = "Mobile: " + profile.mobile;

            PopulateCourierHistory();
            // Populate courier history
            foreach (var historyItem in profile.history)
            {
                courierHistoryGridView.Rows.Add(
                    historyItem.courier_id,
                    historyItem.sender_address,
                    historyItem.src_city,
                    historyItem.receiver_name,
                    historyItem.receiver_address,
                    historyItem.receiver_mobile,
                    historyItem.dest_city,
                    historyItem.status,
                    historyItem.date_of_order.ToString("yyyy-MM-dd")
                );
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void PopulateCourierHistory()
        {
            // Add column headers
            courierHistoryGridView.Columns.Add("CourierNumber", "Courier Number");
            courierHistoryGridView.Columns.Add("SenderAddress", "Sender Address");
            courierHistoryGridView.Columns.Add("SourceCity", "Source City");
            courierHistoryGridView.Columns.Add("ReceiverName", "Receiver Name");
            courierHistoryGridView.Columns.Add("ReceiverAddress", "Receiver Address");
            courierHistoryGridView.Columns.Add("ReceiverMobile", "Receiver Mobile");
            courierHistoryGridView.Columns.Add("DestinationCity", "Destination City");
            courierHistoryGridView.Columns.Add("Status", "Status");
            courierHistoryGridView.Columns.Add("DateOfOrder", "Date of Order");
        }



    }
}
