using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeManagement;

namespace EmployeeWindowsFormApp
{
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            double sal = Convert.ToDouble(txtSal.Text);

            /* string conString = ConfigurationManager.ConnectionStrings["dbmssql"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string query = "update tblEmployee set ename = '" + name +
                "', esal = " + sal + " where eid = " + id;

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            int result = adapter.UpdateCommand.ExecuteNonQuery();*/

            Employee employee = new Employee();
            int result = employee.UpdateEmployee(id, name, sal);
            MessageBox.Show(result + " record updated");
        }
    }
}
