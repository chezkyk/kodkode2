using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class AllCourses : Form
    {
        public List<AllCourses> AllCourse;
        public int Index;
        public AllCourses(List<AllCourses> allCourses, int index, string studentName, string name)
        {
            InitializeComponent();
            AllCourse = allCourses;
            Index = index;
            lblHelloStudent.Text = "Hello " + name;
           
        }

        private void AllCourses_Load(object sender, EventArgs e)
        {
            DataTable dataTable = SqlStudentManager.DisplayCourses();
            dtGrdVwAllCourses.DataSource = dataTable;

            List<string> coureseNames = new List<string>();
            coureseNames = SqlStudentManager.GetCoureseNames();
            int i = 0;
            while (i < coureseNames.LongCount())
            {
                lstBoxNameCourse.Items.Add(coureseNames[i]);
                i++;
            }

            lstBoxNameCourse.DoubleClick += (Sender, E) =>
            {
                string selectedItem = lstBoxNameCourse.SelectedItem.ToString();
                if (selectedItem == " ") return;
                txtBoxNameCourse.Text = selectedItem;



            };
        }

        private void txtBoxNameCourse_TextChanged(object sender, EventArgs e)
        {
            List<string> names = SqlStudentManager.SearchByCoureseName(txtBoxNameCourse.Text);
            lstBoxNameCourse.Items.Clear();
            int i = 0;
            while (i < names.LongCount())
            {
                lstBoxNameCourse.Items.Add(names[i]);
                i++;
            }
            lstBoxNameCourse.DoubleClick += (Sender, E) =>
            {
                if (lstBoxNameCourse.SelectedItem == null) return;
                string selectedItem = lstBoxNameCourse.SelectedItem.ToString();
                if (selectedItem == " ") return;
                txtBoxNameCourse.Text = selectedItem;



            };
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
