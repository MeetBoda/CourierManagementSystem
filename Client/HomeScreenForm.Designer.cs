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
            this.placeRequestButton = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.cancelRequestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeRequestButton
            // 
            this.placeRequestButton.Location = new System.Drawing.Point(12, 12);
            this.placeRequestButton.Name = "placeRequestButton";
            this.placeRequestButton.Size = new System.Drawing.Size(100, 30);
            this.placeRequestButton.Text = "Place Request";
            this.placeRequestButton.UseVisualStyleBackColor = true;
            this.placeRequestButton.Click += new System.EventHandler(this.placeRequestButton_Click);
            // 
            // cancelRequestButton
            // 
            this.cancelRequestButton.Location = new System.Drawing.Point(224, 12);
            this.cancelRequestButton.Name = "cancelRequestButton";
            this.cancelRequestButton.Size = new System.Drawing.Size(100, 30);
            this.cancelRequestButton.Text = "Cancel Request";
            this.cancelRequestButton.UseVisualStyleBackColor = true;
            this.cancelRequestButton.Click += new System.EventHandler(this.cancelRequestButton_Click);
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.Location = new System.Drawing.Point(118, 12);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(100, 30);
            this.viewProfileButton.Text = "View Profile";
            this.viewProfileButton.UseVisualStyleBackColor = true;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.Courier; // Set the background image here
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.placeRequestButton);
            this.Controls.Add(this.cancelRequestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Remove the border
            this.MaximizeBox = false; // Disable maximize button
            this.MinimizeBox = false; // Disable minimize button
            this.Name = "HomeScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Start form in the center of the screen
            this.Text = "Home Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; // Maximize the form
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button placeRequestButton;
        private System.Windows.Forms.Button viewProfileButton;
        private System.Windows.Forms.Button cancelRequestButton;

        #endregion
    }
}