using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Form1 : Form
    {
        Employee[] employeesArr = new Employee[1];
        

        public Form1()
        {
            InitializeComponent();
            TxtBoxCode.Text = employeesArr.Length.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            //Employee employee = new Employee(int.Parse(TxtBoxCode.Text))
            employeesArr[0] = new Employee();

            employeesArr[0].Code = employeesArr.Length;
            employeesArr[0].Id = TxtBoxId.Text;
            employeesArr[0].FirstName = TxtBoxFirstName.Text;
            employeesArr[0].LastName = TxtBoxSecondName.Text;
            employeesArr[0].DateOfBirth = DtTmPckrDateBirth.Value;
            employeesArr[0].IsMale = GetGender();
            employeesArr[0].Status = GetStatus();
            employeesArr[0].PhoneNumber = TxtBoxPhoneNumber.Text;
            employeesArr[0].MobileNumber = TxtBoxMobileNumber.Text;
            employeesArr[0].StreetName = TxtBoxlStreetName.Text;
            employeesArr[0].StreetNumber = TxtBoxStreetNumber.Text;
            employeesArr[0].City = TxtBoxCity.Text;
            // 
            TxtBoxAge.Text = employeesArr[0].Age.ToString();
            //
            Console.WriteLine(employeesArr[0].Code);
            Console.WriteLine(employeesArr[0].Id);
            Console.WriteLine(employeesArr[0].FirstName);
            Console.WriteLine(employeesArr[0].LastName);
            Console.WriteLine(employeesArr[0].DateOfBirth);
            Console.WriteLine(employeesArr[0].IsMale);
            Console.WriteLine(employeesArr[0].Status);
            Console.WriteLine(employeesArr[0].PhoneNumber);
            Console.WriteLine(employeesArr[0].MobileNumber);
            Console.WriteLine(employeesArr[0].StreetName);
            Console.WriteLine(employeesArr[0].StreetNumber);
            Console.WriteLine(employeesArr[0].City);
            ////   
            //if (employeesArr[employeesArr.Length-1] == null)
            //{
            //    employeesArr[employeesArr.Length - 1] = employeesArr;
            //}

            //Employee tmpArr = new Employee[employeesArr.Length + 1];
            //for(int i = 0; i < employeesArr.Length; i++)
            //{
            //    tmpArr[i] = employeesArr[i];
            //}
            //employeesArr = tmpArr;
            //employeesArr[employeesArr.Length-1] = employeesArr






    }
        private string GetStatus()
        {
            if(RdBtnSingle.Checked)
            {
                return "Single";
            }
            else if(RdBtnMarried.Checked)
            {
                return "Married";
            }
            else if(RdBtnDivorcee.Checked)
            {
                return "Divorcee";
            }
            else if(RdBtnWidower.Checked)
            {
                return "Widower";
            }
            else
            {
                return "No Status";
            }
        }

        private string GetGender()
        {
            if(RdBtnMale.Checked)
            {
                return "Male";
            }
            else if(RdBtnFemale.Checked)
            {
                return "Female";
            }
            else
            {
                return "NoGender";
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtBoxCode.Clear();
            TxtBoxId.Clear();
            TxtBoxFirstName.Clear();
            TxtBoxSecondName.Clear();
            //date
            RdBtnMale.Checked = false;
            RdBtnFemale.Checked = false;
            RdBtnSingle.Checked = false;
            RdBtnMarried.Checked = false;
            RdBtnDivorcee.Checked = false; 
            RdBtnWidower.Checked = false;
            TxtBoxPhoneNumber.Clear();
            TxtBoxMobileNumber.Clear();
            TxtBoxlStreetName.Clear();
            TxtBoxStreetNumber.Clear();
            TxtBoxCity.Clear();
            



        }
        
    }
}
