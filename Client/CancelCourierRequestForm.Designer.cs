using System.Windows.Forms;

namespace Client
{
    partial class CancelCourierRequestForm
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
            this.courierNumberTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courierNumberTextBox
            // 
            this.courierNumberTextBox.Location = new System.Drawing.Point(12, 12);
            this.courierNumberTextBox.Name = "courierNumberTextBox";
            this.courierNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.courierNumberTextBox.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 38);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CancelCourierRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 73);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.courierNumberTextBox);
            this.Name = "CancelCourierRequestForm";
            this.Text = "Cancel Courier Request";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox courierNumberTextBox;
        private Button submitButton;

        #endregion
    }
}