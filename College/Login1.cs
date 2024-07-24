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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            names = SqlStudentManager.GetStudents();
            int i = 0;
            while (i < names.LongCount())
            {
                lstBoxNames.Items.Add(names[i]);
                i++;
            }

            lstBoxNames.DoubleClick += (Sender, E) =>
            {
                string selectedItem = lstBoxNames.SelectedItem.ToString();
                if (selectedItem == " ") return;
                textBoxName.Text = selectedItem;



            };
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            List<string> names = SqlStudentManager.SearchByName(textBoxName.Text);
            lstBoxNames.Items.Clear();
            int i = 0;
            while (i < names.LongCount())
            {
                lstBoxNames.Items.Add(names[i]);
                i++;
            }
            lstBoxNames.DoubleClick += (Sender, E) =>
            {
                if (lstBoxNames.SelectedItem == null) return;
                string selectedItem = lstBoxNames.SelectedItem.ToString();
                if (selectedItem == " ") return;
                textBoxName.Text = selectedItem;



            };
        }

        private void btnCourseSignUp_Click(object sender, EventArgs e)
        {
            List<AllCourses> forms = new List<AllCourses>();
            List<string> names = SqlStudentManager.GetStudents();
            for (int i = 0; i < names.Count; i++)
            {
                forms.Add(new AllCourses(forms, i, names[i],textBoxName.Text));
            }
            forms.First().ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnPersonalArea_Click(object sender, EventArgs e)
        {
            List<MyCourses> forms = new List<MyCourses>();
            List<string> names = SqlStudentManager.GetStudents();
            for (int i = 0; i < names.Count; i++)
            {
                forms.Add(new MyCourses(forms, i, names[i], textBoxName.Text));
            }
            forms.First().ShowDialog();
        }
    }
}
