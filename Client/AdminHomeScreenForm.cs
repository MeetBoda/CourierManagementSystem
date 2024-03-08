using Client.AdminServiceReference;
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
    public partial class AdminHomeScreenForm : Form
    {
        public AdminHomeScreenForm()
        {
            InitializeComponent();
            AdminServiceReference.AdminServiceClient adminServiceClient = new AdminServiceReference.AdminServiceClient();
            List<AdminData> adminData = adminServiceClient.getData().ToList();

            foreach (var courierItem in adminData)
            {
               /* Button btn1 = new Button();
                btn1.Text = "Add";
                Button btn2 = new Button();
                btn2.Text = "Add";*/
                dataGridView1.Rows.Add(
                    courierItem.courier_id,
                    courierItem.sender_id,
                    courierItem.receiver_name,
                    courierItem.receiver_address,
                    courierItem.dest_city,
                    courierItem.employee_id,
                    courierItem.status
/*
                    btn1,
                    btn2*/
                );
            }
        }

        private void AdminHomeScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["CourierId"].Value != null)
            {
                int courierId = (int)dataGridView1.Rows[e.RowIndex].Cells["CourierId"].Value;
                if (e.ColumnIndex == dataGridView1.Columns["AssignDeliveryPerson"].Index)
                {
                    // Open form to assign delivery person
                    AssignDeliveryPersonForm assignForm = new AssignDeliveryPersonForm(courierId);
                    assignForm.ShowDialog();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["ChangeStatus"].Index)
                {
                    // Open form to change status
                    ChangeStatusForm statusForm = new ChangeStatusForm(courierId);
                    statusForm.ShowDialog();
                }
            }
        }

        public void ReloadData()
        {
            dataGridView1.Rows.Clear(); // Clear existing rows
            AdminServiceReference.AdminServiceClient adminServiceClient = new AdminServiceReference.AdminServiceClient();
            List<AdminData> adminData = adminServiceClient.getData().ToList();

            foreach (var courierItem in adminData)
            {
                dataGridView1.Rows.Add(
                    courierItem.courier_id,
                    courierItem.sender_id,
                    courierItem.receiver_name,
                    courierItem.receiver_address,
                    courierItem.dest_city,
                    courierItem.employee_id,
                    courierItem.status
                );
            }
        }

    }
}
