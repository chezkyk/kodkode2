using GuestsForShabbat;
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

namespace Guests
{
    public partial class Form2 : Form
    {
        public List<Form2> Forms2;
        public int Index;
        public string GustName;
        public Form2(List<Form2> form2, int index,  string categoreys, string guestName)
        {
            InitializeComponent();
            Forms2 = form2;
            Index = index;
            lblCategory.Text = categoreys;
            GustName = guestName;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dataTable1 = SqlShabbatManager.DisplayDishes(GustName ,lblCategory.Text);
            dtGrdVwGuestsChoice.DataSource = dataTable1;

            DataTable dataTable2 = SqlShabbatManager.DisplayMyDishes(GustName, lblCategory.Text);
            dtGrdVwMyChoice.DataSource = dataTable2;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Forms2[Index].Visible = false;
            if (Index > 0)
            {
                Forms2[Index - 1].Visible = true;
            }
            else
            {
                Forms2[Forms2.Count - 1].Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Forms2[Index].Visible = false;
            if (Index < Forms2.Count - 1)
            {
                Forms2[Index + 1].Visible = true;
            }
            else
            {

                Forms2[0].Visible = true;

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlShabbatManager.AddDish(lblCategory.Text, GustName, txtBoxAddSelection.Text);
            txtBoxAddSelection.Text = null;
            DataTable dataTable1 = SqlShabbatManager.DisplayDishes(GustName, lblCategory.Text);
            dtGrdVwGuestsChoice.DataSource = dataTable1;

            DataTable dataTable2 = SqlShabbatManager.DisplayMyDishes(GustName, lblCategory.Text);
            dtGrdVwMyChoice.DataSource = dataTable2;

        }

        private void btnAddSelection_Click(object sender, EventArgs e)
        {
            txtBoxAddSelection.Visible = true;
            btnOk.Visible = true;
        }
    }
}
