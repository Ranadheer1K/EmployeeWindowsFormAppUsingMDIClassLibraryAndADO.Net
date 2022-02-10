using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeWindowsFormApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
            {
                lblUserWarn.Visible = true;
            }

            if (txtPwd.Text == string.Empty)
            {
                lblPwdWarn.Visible = true;
            }
            else if (!Regex.Match(txtUser.Text, "^[A_Za-z0-9]*$").Success)
            {
                MessageBox.Show("Numbers not allowed");
                txtUser.Focus();
            }
            else if (txtPwd.Text == "admin")
            {
                lblUserWarn.Visible = false;
                lblPwdWarn.Visible = false;

                this.Hide();

                empFormMDI empObj = new empFormMDI();
                empObj.Show();
            }

        }
    }
}
