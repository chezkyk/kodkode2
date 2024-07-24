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

namespace Guests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            List<string> forms = new List<string>();
            List<string> guestes = SqlShabbatManager.GetGuestes();
            for (int i = 0; i < guestes.Count; i++)
            {
                listBoxGuset.Items.Add(guestes[i]);
            }

            listBoxGuset.DoubleClick += (Sender, E) =>
            {
                string selectedItem = listBoxGuset.SelectedItem.ToString();
                if (selectedItem == " ") return;
                txtBoxGuests.Text = selectedItem;



            };
        }

        private void txtBoxGuests_TextChanged(object sender, EventArgs e)
        {
            List<string> categories1 = SqlShabbatManager.SearchByName(txtBoxGuests.Text);
            listBoxGuset.Items.Clear();
            int i = 0;
            while (i < categories1.LongCount())
            {
                listBoxGuset.Items.Add(categories1[i]);
                i++;
            }
            listBoxGuset.DoubleClick += (Sender, E) =>
            {
                if (listBoxGuset.SelectedItem == null) return;
                string selectedItem = listBoxGuset.SelectedItem.ToString();
                if (selectedItem == " ") return;
                listBoxGuset.Text = selectedItem;



            };

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlShabbatManager.AddName(txtBoxGuests.Text);

            List<string> guestes = SqlShabbatManager.GetGuestes();
            int i = 0;
            while (i < guestes.LongCount())
            {
                listBoxGuset.Items.Add(guestes[i]);
                i++;
            }
            txtBoxGuests.Text = null;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlShabbatManager.DeleteName(txtBoxGuests.Text);

            List<string> guestes = SqlShabbatManager.GetGuestes();
            int i = 0;
            while (i < guestes.LongCount())
            {
                listBoxGuset.Items.Add(guestes[i]);
                i++;
            }
            txtBoxGuests.Text = null;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Form2> forms = new List<Form2>();
            List<string> categoreys = SqlShabbatManager.GetCategories();
            for (int i = 0; i < categoreys.Count; i++)
            {
                forms.Add(new Form2(forms, i, categoreys[i],txtBoxGuests.Text));
            }
            forms.First().ShowDialog();
        }
        private void dtGrdVwHost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBoxGuset_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
