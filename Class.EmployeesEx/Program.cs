using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class.EmployeesEx
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Employee[] employees = new Employee[2];

            employees[0] = new Employee("Chezky", Department.Marketing);
            employees[1] = new Employee("Tal", Department.Engineering);

            Company company = new Company(employees);
            company.DisplayAllEmployees();
        }
    }
}
