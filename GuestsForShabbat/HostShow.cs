using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestsForShabbat
{
    public partial class Form2 : Form
    {
        public List<Form2> Forms2;
        public int Index;

        public Form2(List<Form2> form2, int index, string categoreiName)
        {
            InitializeComponent();
            Forms2 = form2;
            Index = index;
            lblCategory.Text = categoreiName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            DataTable dataTable = SqlShabbatManager.DisplayDishes(lblCategory.Text);
            dtGrdVwHost.DataSource = dataTable;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Forms2[Index].Visible = false;
            if (Index > 0)
            {
                Forms2[Index-1].Visible = true;
            }
            else
            {
                Forms2[Forms2.Count - 1].Visible = true;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Forms2[Index].Visible = false;
            if (Index < Forms2.Count-1)
            {
                Forms2[Index+1].Visible = true;
            }
            else
            {

                Forms2[0].Visible = true;

            }

        }
    }
}