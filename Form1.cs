using System;
using System.Windows.Forms;

namespace EmployeeWindowsFormApp
{
    public partial class empFormMDI : Form
    {
        public empFormMDI()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertEmployee iEmp = new InsertEmployee();
            iEmp.Show();
            iEmp.MdiParent = this;
        }

        private void fetchEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetEmployee gEmp = new GetEmployee();
            gEmp.Show();
            gEmp.MdiParent = this;
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployee dEmp = new DeleteEmployee();
            dEmp.Show();
            dEmp.MdiParent = this;
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEmployee uEmp = new UpdateEmployee();
            uEmp.Show();
            uEmp.MdiParent = this;
        }
    }
}
