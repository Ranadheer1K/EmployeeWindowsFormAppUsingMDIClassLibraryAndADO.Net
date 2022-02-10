namespace EmployeeWindowsFormApp
{
    partial class UpdateEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Update Form";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(390, 112);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 1;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(390, 330);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(91, 34);
            this.btnUpdateEmp.TabIndex = 2;
            this.btnUpdateEmp.Text = "Update";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(268, 115);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(69, 20);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Enter ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(268, 181);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Enter Name";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(268, 247);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(75, 20);
            this.lblSal.TabIndex = 5;
            this.lblSal.Text = "Enter Sal";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(390, 175);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(390, 244);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(100, 26);
            this.txtSal.TabIndex = 7;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSal;
    }
}