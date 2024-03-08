using System;
using System.Windows.Forms;

namespace Client
{
    partial class AdminHomeScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "CourierId", DataPropertyName = "CourierId", HeaderText = "Courier ID" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "SenderId", DataPropertyName = "SenderId", HeaderText = "Sender ID" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ReceiverName", DataPropertyName = "ReceiverName", HeaderText = "Receiver Name" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ReceiverAddress", DataPropertyName = "ReceiverAddress", HeaderText = "Receiver Address" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "DestinationCity", DataPropertyName = "DestinationCity", HeaderText = "Destination City" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "DeliveryPerson", DataPropertyName = "DeliveryPerson", HeaderText = "Delivery Person" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Status" },
            new System.Windows.Forms.DataGridViewButtonColumn { Name = "AssignDeliveryPerson", HeaderText = "Assign Delivery Person", Text = "Assign", UseColumnTextForButtonValue = true },
            new System.Windows.Forms.DataGridViewButtonColumn { Name = "ChangeStatus", HeaderText = "Change Status", Text = "Change Status", UseColumnTextForButtonValue = true }
            });
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false; // Hide row headers
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminHomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminHomeScreenForm";
            this.Text = "Admin Home Screen";
            this.Load += new System.EventHandler(this.AdminHomeScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

            // Add column headers
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Value = column.HeaderText;
            }
            dataGridView1.ColumnHeadersVisible = true;
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}