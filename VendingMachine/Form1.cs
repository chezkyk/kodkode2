using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace Vending_machine
{
    public partial class Form1 : Form
    {
        private DrinksManager drinksManager;
        public Form1()
        {
            InitializeComponent();
            XmlDocument drinksDocument = MainProject.Main();
            drinksManager = new DrinksManager(drinksDocument);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<List<string>> drinksList = drinksManager.GetDrinksData();
            foreach (List<string> drink in drinksList)
            {
                dataGridViewAllDrinks.Rows.Add(drink.ToArray());
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            drinksManager.Save();
        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtBoxPrice.Text == "")
            {
                txtBoxPrice.Text = "0";
            }
            txtBoxPrice.Text = (float.Parse(txtBoxPrice.Text) + 0.5f).ToString();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtBoxPrice.Text == "")
            {
                txtBoxPrice.Text = "0.5";
            }
            if (float.Parse(txtBoxPrice.Text) > 0.5f)
            {

                txtBoxPrice.Text = (float.Parse(txtBoxPrice.Text) - 0.5f).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                txtBoxDrinkName.Text,
                cmboBxCoffee.Text,
                cmboBxSugar.Text,
                cmboBxMilk.Text,
                cmboBxCocoa.Text,
                txtBoxPrice.Text,
            };
            drinksManager.AddDrink(drinks);

            dataGridViewAllDrinks.Rows.Add(drinks.ToArray());

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                txtBoxDrinkName.Text,
                cmboBxCoffee.Text,
                cmboBxSugar.Text,
                cmboBxMilk.Text,
                cmboBxCocoa.Text,
                txtBoxPrice.Text,
            };
            drinksManager.UpdateDrink(drinks);
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            dataGridViewAllDrinks.Rows.Clear();
            List<List<string>> drinksList = drinksManager.GetDrinksData();
            foreach (List<string> drink in drinksList)
            {
                dataGridViewAllDrinks.Rows.Add(drink.ToArray());
            }

        }

        private void txtBoxDrinkName_TextChanged(object sender, EventArgs e)
        {
            List<string> drinks = drinksManager.GetDrinksByName(txtBoxDrinkName.Text);
            if (drinks == null) { return; }
            DialogResult result = MessageBox.Show($"do you want to update {txtBoxDrinkName.Text}", "update drink", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                cmboBxCoffee.Text = drinks[1];
                cmboBxSugar.Text = drinks[2];
                cmboBxMilk.Text = drinks[3];
                cmboBxCocoa.Text = drinks[4];
                txtBoxPrice.Text = drinks[5];
                btnUpdate.Visible = true;
                btnAdd.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {txtBoxDrinkName.Text}?", "Delete drink", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                drinksManager.DeleteDrink(txtBoxDrinkName.Text);

                
                drinksManager.Save();

                dataGridViewAllDrinks.Rows.Clear();
                List<List<string>> drinksList = drinksManager.GetDrinksData();
                foreach (List<string> drink in drinksList)
                {
                    dataGridViewAllDrinks.Rows.Add(drink.ToArray());
                }

                txtBoxDrinkName.Clear();
                cmboBxCoffee.SelectedIndex = -1;
                cmboBxSugar.SelectedIndex = -1;
                cmboBxMilk.SelectedIndex = -1;
                cmboBxCocoa.SelectedIndex = -1;
                txtBoxPrice.Clear();
            }
        }
    }
}
