﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Student
    {
        public Student() { }
        public Student(string firstName ,string lastName)
        { 
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id;
        public string FirstName;
        public string LastName;


    }
}
