namespace Client
{
    partial class RegisterForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.mobileNoLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mobileNoTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(40, 37);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(79, 16);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(40, 74);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 16);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(40, 111);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // mobileNoLabel
            // 
            this.mobileNoLabel.AutoSize = true;
            this.mobileNoLabel.Location = new System.Drawing.Point(40, 148);
            this.mobileNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mobileNoLabel.Name = "mobileNoLabel";
            this.mobileNoLabel.Size = new System.Drawing.Size(72, 16);
            this.mobileNoLabel.TabIndex = 3;
            this.mobileNoLabel.Text = "Mobile No:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(133, 33);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(199, 22);
            this.userNameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(133, 70);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(199, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(133, 107);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(199, 22);
            this.passwordTextBox.TabIndex = 6;
            // 
            // mobileNoTextBox
            // 
            this.mobileNoTextBox.Location = new System.Drawing.Point(133, 144);
            this.mobileNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mobileNoTextBox.Name = "mobileNoTextBox";
            this.mobileNoTextBox.Size = new System.Drawing.Size(199, 22);
            this.mobileNoTextBox.TabIndex = 7;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(133, 181);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 28);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginLinkLabel
            // 
            this.loginLinkLabel.AutoSize = true;
            this.loginLinkLabel.Location = new System.Drawing.Point(129, 228);
            this.loginLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.Size = new System.Drawing.Size(40, 16);
            this.loginLinkLabel.TabIndex = 9;
            this.loginLinkLabel.TabStop = true;
            this.loginLinkLabel.Text = "Login";
            this.loginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLabel_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.loginLinkLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.mobileNoTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.mobileNoLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.userNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label mobileNoLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox mobileNoTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.LinkLabel loginLinkLabel;


        #endregion
    }
}

