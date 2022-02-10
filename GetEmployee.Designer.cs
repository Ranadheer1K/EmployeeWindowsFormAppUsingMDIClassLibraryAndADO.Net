namespace EmployeeWindowsFormApp
{
    partial class GetEmployee
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
            this.dgvGetEmp = new System.Windows.Forms.DataGridView();
            this.btnFetchEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGetEmp
            // 
            this.dgvGetEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetEmp.Location = new System.Drawing.Point(231, 88);
            this.dgvGetEmp.Name = "dgvGetEmp";
            this.dgvGetEmp.RowHeadersWidth = 62;
            this.dgvGetEmp.RowTemplate.Height = 28;
            this.dgvGetEmp.Size = new System.Drawing.Size(706, 431);
            this.dgvGetEmp.TabIndex = 0;
            // 
            // btnFetchEmp
            // 
            this.btnFetchEmp.Location = new System.Drawing.Point(460, 562);
            this.btnFetchEmp.Name = "btnFetchEmp";
            this.btnFetchEmp.Size = new System.Drawing.Size(195, 64);
            this.btnFetchEmp.TabIndex = 1;
            this.btnFetchEmp.Text = "Fetch Employees";
            this.btnFetchEmp.UseVisualStyleBackColor = true;
            this.btnFetchEmp.Click += new System.EventHandler(this.btnFetchEmp_Click);
            // 
            // GetEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 682);
            this.Controls.Add(this.btnFetchEmp);
            this.Controls.Add(this.dgvGetEmp);
            this.Name = "GetEmployee";
            this.Text = "GetEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGetEmp;
        private System.Windows.Forms.Button btnFetchEmp;
    }
}