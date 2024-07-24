using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class AddCourses : Form
    {
        public AddCourses()
        {
            InitializeComponent();
        }
        private void AddCourses_Load(object sender, EventArgs e)
        {
            DataTable dataTable = SqlAdministratorManager.DisplayAllCourses();
            dtGrdVwAllCourses.DataSource = dataTable;
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            
            SqlAdministratorManager.AddCourse(txtBoxCourseName.Text, txtBoxStartDay.Text,int.Parse(txtBoxDaysAWeek.Text),txtBoxStudyHours.Text,float.Parse(txtBoxPrice.Text));
            txtBoxCourseName.Text = null;
            txtBoxStartDay.Text = null;
            txtBoxDaysAWeek.Text = null;
            txtBoxStudyHours.Text = null;
            txtBoxPrice.Text = null;
            MessageBox.Show("Course has been successfully added");
            this.Close();
        }

        private void btnShowInterested_Click(object sender, EventArgs e)
        {
            Interested interested = new Interested();
            interested.Show();

        }


    }
}
