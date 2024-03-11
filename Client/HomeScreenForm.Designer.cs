using System;
using System.Drawing;

namespace Client
{
    partial class HomeScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreenForm));
            this.placeRequestButton = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.cancelRequestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeRequestButton
            // 
            this.placeRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.placeRequestButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeRequestButton.ForeColor = System.Drawing.Color.White;
            this.placeRequestButton.Location = new System.Drawing.Point(13, 15);
            this.placeRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.placeRequestButton.Name = "placeRequestButton";
            this.placeRequestButton.Size = new System.Drawing.Size(245, 43);
            this.placeRequestButton.TabIndex = 0;
            this.placeRequestButton.Text = "Place Request";
            this.placeRequestButton.UseVisualStyleBackColor = false;
            this.placeRequestButton.Click += new System.EventHandler(this.placeRequestButton_Click);
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.viewProfileButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProfileButton.ForeColor = System.Drawing.Color.White;
            this.viewProfileButton.Location = new System.Drawing.Point(284, 15);
            this.viewProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(256, 43);
            this.viewProfileButton.TabIndex = 1;
            this.viewProfileButton.Text = "View Profile";
            this.viewProfileButton.UseVisualStyleBackColor = false;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // cancelRequestButton
            // 
            this.cancelRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.cancelRequestButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelRequestButton.ForeColor = System.Drawing.Color.White;
            this.cancelRequestButton.Location = new System.Drawing.Point(563, 15);
            this.cancelRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelRequestButton.Name = "cancelRequestButton";
            this.cancelRequestButton.Size = new System.Drawing.Size(237, 43);
            this.cancelRequestButton.TabIndex = 2;
            this.cancelRequestButton.Text = "Cancel Request";
            this.cancelRequestButton.UseVisualStyleBackColor = false;
            this.cancelRequestButton.Click += new System.EventHandler(this.cancelRequestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello " + LoginInfo.UserName;

            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(1160, 15);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(125, 43);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelRequestButton);
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.placeRequestButton);
            this.Controls.Add(this.logoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();


        }
/*
        private void HomeScreenForm_Resize(object sender, EventArgs e)
        {
            label1.Location = new Point(ClientSize.Width - label1.Width - 20, 15);
        }*/

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private System.Windows.Forms.Button placeRequestButton;
        private System.Windows.Forms.Button viewProfileButton;
        private System.Windows.Forms.Button cancelRequestButton;
        private System.Windows.Forms.Button logoutButton;

        #endregion

        private System.Windows.Forms.Label label1;
    }
}