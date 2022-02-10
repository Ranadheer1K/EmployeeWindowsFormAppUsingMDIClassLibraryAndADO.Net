using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeManagement;


namespace EmployeeWindowsFormApp
{
    public partial class InsertEmployee : Form
    {
        public InsertEmployee()
        {
            InitializeComponent();
        }

        private void btnInsertEmp_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            double sal = double.Parse(txtSal.Text);

            /*
            string conString = ConfigurationManager.ConnectionStrings["dbmssql"].ConnectionString;
            string query = "select * from tblEmployee";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conString);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "tblEmployee");

            DataRow row = dset.Tables["tblEmployee"].NewRow();
            row["eid"] = id;
            row["ename"] = name;
            row["esal"] = sal;

            dset.Tables["tblEmployee"].Rows.Add(row);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dset.Tables["tblEmployee"]);*/

            Employee employee = new Employee();
            int result = employee.AddEmployee(id, name, sal);

            MessageBox.Show(result + " Employee record inserted");
        }
    }
}
