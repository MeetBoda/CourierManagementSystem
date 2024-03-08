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
    public partial class AssignDeliveryPersonForm : Form
    {

        private int courierId;
        private AdminServiceReference.AdminServiceClient adminServiceClient;
        private List<int> empList;


        public AssignDeliveryPersonForm(int courier_id)
        {
            InitializeComponent();
            courierId = courier_id;
            adminServiceClient = new AdminServiceReference.AdminServiceClient();
            List<int> empList = adminServiceClient.getEmployeeList().ToList();

            // Populate the ComboBox with employee IDs
            comboBox1.DataSource = empList;
        }

        private void AssignDeliveryPersonForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the selected employee ID
            int selectedEmployeeId = (int)comboBox1.SelectedItem;

            // Assign the delivery person (assuming this method exists in your service)
            adminServiceClient.assigndeliveryperson(courierId, selectedEmployeeId);

            AdminHomeScreenForm adminHomeScreenForm = Application.OpenForms["AdminHomeScreenForm"] as AdminHomeScreenForm;
            if (adminHomeScreenForm != null)
            {
                adminHomeScreenForm.ReloadData();
            }
            // Close the form
            this.Close();

        }
    }
}
