using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox selectedTextBox;
        private ComboBox selectedComboBox;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void textNum1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textNum2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Operator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnEqual_Click(object sender, EventArgs e)
        {
            //1.Convert 'string' to int
            double num1 = double.Parse(textNum1.Text);
            double num2 = double.Parse(textNum2.Text);
            //2. Validate inputs
            //-  
            //-

            //3. Perform calculation
            switch(Operator.Text)
            {
                case("+"):
                    lblResult.Text = (num1 + num2).ToString();

                    break;

           
                case("-"):
                    lblResult.Text = (num1 - num2).ToString();
                break;

            
            
                case("*"):
                    lblResult.Text = (num1 * num2).ToString();

                break;

            
            
                case("/"):
                    if (num2 == 0)
                    {
                        lblResult.Text = "ERROR, you can't divide by zero";
                        return;
                    }
                    else
                    {

                        lblResult.Text = (num1 / num2).ToString();
                    }
                    break;
                case("power"):
                        lblResult.Text = Math.Pow(num1, num2).ToString();
                    break;
                case ("root"):
                    lblResult.Text = Math.Sqrt(num1).ToString();
                    break;






            }
            textNum1.Text = null;
            textNum2.Text = null;

        }
            

        private void textNum1_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void textNum2_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }
        private void Operator_Enter(object sender, EventArgs e)
        {
            selectedComboBox = sender as ComboBox;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            selectedComboBox.Text = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            selectedComboBox.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            selectedComboBox.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            selectedComboBox.Text = "/";
        }
        private void btnPower_Click(object sender, EventArgs e)
        {
            selectedComboBox.Text = "power";
        }
        private void btnRoot_Click(object sender, EventArgs e)
        {
            selectedComboBox.Text = "root";
            textNum2.Enabled = false;
            textNum2.Text = null;
        }

        private void textNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar ) && e.KeyChar != '.')
            {
                lblResult.Text = "no valid char";
                return;
            }
            else
            {
                lblResult.Text = string.Empty;
            }
        }

        private void textNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                lblResult.Text = "no valid char";
                return;
            }
            else
            {
                lblResult.Text = string.Empty;
            }       
        }
        private void btn_Click_Global(object sender, EventArgs e)
        {
            selectedTextBox.Text += ((Button)sender).Text;
        }

    }
}
