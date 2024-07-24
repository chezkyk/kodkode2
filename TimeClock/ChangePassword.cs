using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            string result = EmployeeManagement.ChangePassword(txtBoxChangePasswordID.Text, txtBoxOldPassword.Text, txtBoxNewPassword.Text, txtBoxConfirmNewPassword.Text);
            MessageBox.Show(result);

        }

        private void txtBoxChangePasswordID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
