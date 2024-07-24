using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.EmployeesEx
{
    internal class Company
    {
        private Employee[] _employees;
        public Company(Employee[] employees)
        {
            _employees = employees;
        }
        public void DisplayAllEmployees()
        {
            foreach (var employee in _employees)
            {
                employee.DisplayInfo();
            }
        }
    }
}
