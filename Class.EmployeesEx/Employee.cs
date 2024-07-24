using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class.EmployeesEx
{
    internal class Employee
    {
        private string _name;
        private Department _department;

        public Employee(string name, Department department)
        {
            _name = name;
            _department = department;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(($"Name: {_name}, Department: {_department}"));
            
        }
    }
}
