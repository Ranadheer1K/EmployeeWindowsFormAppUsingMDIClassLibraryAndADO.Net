namespace EmployeeWindowsFormApp
{
    partial class InsertEmployee
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnInsertEmp = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(228, 85);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(66, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Enter Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(376, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 1;
            // 
            // btnInsertEmp
            // 
            this.btnInsertEmp.Location = new System.Drawing.Point(376, 292);
            this.btnInsertEmp.Name = "btnInsertEmp";
            this.btnInsertEmp.Size = new System.Drawing.Size(100, 42);
            this.btnInsertEmp.TabIndex = 2;
            this.btnInsertEmp.Text = "Insert";
            this.btnInsertEmp.UseVisualStyleBackColor = true;
            this.btnInsertEmp.Click += new System.EventHandler(this.btnInsertEmp_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(228, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter Name";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(226, 203);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(96, 20);
            this.lblSal.TabIndex = 4;
            this.lblSal.Text = "Enter Salary";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(376, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(376, 197);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(100, 26);
            this.txtSal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Insertion Form";
            // 
            // InsertEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnInsertEmp);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "InsertEmployee";
            this.Text = "InsertEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnInsertEmp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label4;
    }
}