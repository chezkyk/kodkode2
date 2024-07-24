using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Person
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Age not valid");
                }
                else
                {
                    Console.WriteLine("Age added successful");
                    _age = value;
                }
            }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                char firstLeeter = value[0];
                if (!char.IsUpper(firstLeeter))
                {
                    Console.WriteLine("Name not valid");
                }
                else
                {
                    Console.WriteLine("Name added successful");
                    _name = value;
                }
            }
        }
        public Person() {}
    }
}
