
using System;

namespace ISDS309_FinalProject_Vending
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPassowrd = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(33, 101);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(63, 15);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username:";
			// 
			// lblName
			// 
			this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(33, 43);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(42, 15);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// lblPassword
			// 
			this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(33, 130);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(60, 15);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password:";
			// 
			// lblEmail
			// 
			this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(33, 72);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(39, 15);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "Email:";
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsername.Location = new System.Drawing.Point(100, 98);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(166, 23);
			this.txtUsername.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtName.Location = new System.Drawing.Point(100, 40);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(166, 23);
			this.txtName.TabIndex = 0;
			// 
			// txtPassowrd
			// 
			this.txtPassowrd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPassowrd.Location = new System.Drawing.Point(100, 127);
			this.txtPassowrd.Name = "txtPassowrd";
			this.txtPassowrd.Size = new System.Drawing.Size(166, 23);
			this.txtPassowrd.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmail.Location = new System.Drawing.Point(100, 69);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(166, 23);
			this.txtEmail.TabIndex = 1;
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLogin.Location = new System.Drawing.Point(191, 173);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 224);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPassowrd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblUsername);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassowrd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogin;
    }
}

