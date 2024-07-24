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
    public partial class MyCourses : Form
    {
        public List<MyCourses> MyCourse;
        public int Index;
        public string Label;
        public MyCourses(List<MyCourses> myCourses, int index, string studentName, string name)
        {
            InitializeComponent();
            MyCourse = myCourses;
            Index = index;
            lblHelloStudent.Text = "Hello " + name;
            Label = name;
        }




        private void MyCourses_Load(object sender, EventArgs e)
        {
            DataTable dataTable = SqlStudentManager.DisplayMyCourses(Label);
            dtGrdVwMyCourses.DataSource = dataTable;
            
            lblDebtBalance.Text = "Your debt is: " + SqlStudentManager.GetDebt(Label);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlStudentManager.UpdateDebt(Label, float.Parse(txtBoxEnterAmount.Text));
            lblDebtBalance.Text = "Your debt is: " + SqlStudentManager.GetDebt(Label);
            txtBoxEnterAmount.Text = null;
        }
    }
}
