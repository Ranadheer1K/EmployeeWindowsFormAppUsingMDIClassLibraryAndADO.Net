using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeManagement;

namespace EmployeeWindowsFormApp
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEId.Text);

            /*string conString = ConfigurationManager.ConnectionStrings["dbmssql"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            string query = "delete from tblEmployee where eid = " + id;

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            int recordAffected = adapter.DeleteCommand.ExecuteNonQuery();*/

            Employee emp = new Employee();
            int recordAffected = emp.DeleteEmployee(id);
            MessageBox.Show(recordAffected + " record deleted");
        }
    }
}
