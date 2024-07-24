using Host;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestsForShabbat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYourOrder_Click(object sender, EventArgs e)
        {
            List<Form2> forms = new List<Form2>();
            List<string> categories = SqlShabbatManager.GetCategories();
            for(int i = 0; i < categories.Count; i++)
            {
                forms.Add(new Form2(forms, i, categories[i]));
            }   
            forms.First().ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            List<string> categories = new List<string>();
            categories = SqlShabbatManager.GetCategories();
            int i = 0;
            while (i < categories.LongCount())
            {
                listBoxHost.Items.Add(categories[i]);
                i++;
            }
            
            listBoxHost.DoubleClick += (Sender, E) =>
            {
                string selectedItem = listBoxHost.SelectedItem.ToString();
                if (selectedItem == " ") return;
                txtBoxCategory.Text = selectedItem;



            };
        }
        private void txtBoxCategory_TextChanged(object sender, EventArgs e)
        {
            List<string> categories1 = SqlShabbatManager.SearchByName(txtBoxCategory.Text);
            listBoxHost.Items.Clear();
            int i = 0;
            while (i < categories1.LongCount())
            {
                listBoxHost.Items.Add(categories1[i]);
                i++;
            }
            listBoxHost.DoubleClick += (Sender, E) =>
            {   if(listBoxHost.SelectedItem == null)return;
                string selectedItem = listBoxHost.SelectedItem.ToString();
                if (selectedItem == " ") return;
                txtBoxCategory.Text = selectedItem;



            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlShabbatManager.AddCategorey(txtBoxCategory.Text);

            List<string> categories = SqlShabbatManager.GetCategories();
            int i = 0;
            while (i < categories.LongCount())
            {
                listBoxHost.Items.Add(categories[i]);
                i++;
            }
            txtBoxCategory.Text = null;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlShabbatManager.DeleteCategorey(txtBoxCategory.Text);

            List<string> categories = SqlShabbatManager.GetCategories();
            int i = 0;
            while (i < categories.LongCount())
            {
                listBoxHost.Items.Add(categories[i]);
                i++;
            }
            txtBoxCategory.Text = null;
        }
    }
}














