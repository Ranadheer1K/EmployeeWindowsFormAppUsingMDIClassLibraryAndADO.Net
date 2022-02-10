using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeWindowsFormApp
{
    public partial class GetEmployee : Form
    {
        public GetEmployee()
        {
            InitializeComponent();
        }

        private void btnFetchEmp_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["dbmssql"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            string query = "select * from tblEmployee";

            //SqlDataAdapter adapter = new SqlDataAdapter(query, conString);   
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, con);
            //MessageBox.Show(adapter.SelectCommand.CommandText);
            DataSet dset = new DataSet();

            int recordsAffected = adapter.Fill(dset, "tblEmployee");
            dgvGetEmp.DataSource = dset.Tables["tblEmployee"];
            MessageBox.Show(recordsAffected + " Records Fetched");

        }
    }
}
