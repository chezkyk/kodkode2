using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblEnterPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxEnterPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)return;
            
                
            string result = EmployeeManagement.Login(txtBoxEnterID.Text, txtBoxEnterPassword.Text);
            MessageBox.Show("ID: " + txtBoxEnterID.Text + "\nPassword: " + txtBoxEnterPassword.Text);
            MessageBox.Show(result);


            



        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword formChangePassword = new ChangePassword();
            formChangePassword.Show();
            //this.Hide();


        }

        private void btnShowiWorkingHours_Click(object sender, EventArgs e)
        {
            ShowiWorkingHours formShowiWorkingHours = new ShowiWorkingHours();
            formShowiWorkingHours.Show();
            //this.Hide();
        }
    }
}
