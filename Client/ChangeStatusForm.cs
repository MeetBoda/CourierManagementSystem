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
    public partial class ChangeStatusForm : Form
    {
        private int courierId;
        private AdminServiceReference.AdminServiceClient adminServiceClient;
        public ChangeStatusForm(int courier_id)
        {
            InitializeComponent();
            courierId = courier_id;
            adminServiceClient = new AdminServiceReference.AdminServiceClient();
            comboBoxStatus.Items.AddRange(new string[] { "Order Placed", "Out for Delivery", "Delivered" });
            // Set the initial selected item
            comboBoxStatus.SelectedIndex = 0;

        }

        private void ChangeStatusForm_Load(object sender, EventArgs e)
        {

        }

        public string SelectedStatus
        {
            get { return comboBoxStatus.SelectedItem?.ToString(); }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string new_status = SelectedStatus;
            adminServiceClient.changestatus(courierId, new_status);

            AdminHomeScreenForm adminHomeScreenForm = Application.OpenForms["AdminHomeScreenForm"] as AdminHomeScreenForm;
            if (adminHomeScreenForm != null)
            {
                adminHomeScreenForm.ReloadData();
            }
            this.Close();
        }
    }
}
