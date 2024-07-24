using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Employee
    {
        public int Code;
        public string Id;
        public string FirstName;
        public string LastName;
        public string FullName { get { return FirstName + " " + LastName; } }
        public DateTime DateOfBirth;
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
        public string IsMale;
        public string Status;
        public string PhoneNumber;
        public string MobileNumber;
        public string StreetName;
        public string StreetNumber;
        public string City;
        public string HomeAdress{get{ return City + ", " + StreetName + StreetName;  }}

        public Employee() { }
        public Employee(int code, string id, string firstName, string lastName,  DateTime dateOfBirth, string isMale, string status, string phoneNumber, string mobileNumber, string streetName, string streetNumber, string city)
        {
            Code = code;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            IsMale = isMale;
            Status = status;
            PhoneNumber = phoneNumber;
            MobileNumber = mobileNumber;
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
        }
    }
}
