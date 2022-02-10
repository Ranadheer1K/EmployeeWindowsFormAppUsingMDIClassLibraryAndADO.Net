namespace EmployeeWindowsFormApp
{
    partial class Login
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserWarn = new System.Windows.Forms.Label();
            this.lblPwdWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(205, 80);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(205, 182);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(78, 20);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(337, 80);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '*';
            this.txtUser.Size = new System.Drawing.Size(100, 26);
            this.txtUser.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(337, 176);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 26);
            this.txtPwd.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(337, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUserWarn
            // 
            this.lblUserWarn.AutoSize = true;
            this.lblUserWarn.BackColor = System.Drawing.Color.Transparent;
            this.lblUserWarn.ForeColor = System.Drawing.Color.Red;
            this.lblUserWarn.Location = new System.Drawing.Point(285, 80);
            this.lblUserWarn.Name = "lblUserWarn";
            this.lblUserWarn.Size = new System.Drawing.Size(15, 20);
            this.lblUserWarn.TabIndex = 5;
            this.lblUserWarn.Text = "*";
            // 
            // lblPwdWarn
            // 
            this.lblPwdWarn.AutoSize = true;
            this.lblPwdWarn.ForeColor = System.Drawing.Color.Red;
            this.lblPwdWarn.Location = new System.Drawing.Point(285, 182);
            this.lblPwdWarn.Name = "lblPwdWarn";
            this.lblPwdWarn.Size = new System.Drawing.Size(15, 20);
            this.lblPwdWarn.TabIndex = 6;
            this.lblPwdWarn.Text = "*";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPwdWarn);
            this.Controls.Add(this.lblUserWarn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserWarn;
        private System.Windows.Forms.Label lblPwdWarn;
    }
}