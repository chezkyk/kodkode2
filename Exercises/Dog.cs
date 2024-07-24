using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Dog
    {
        private string _name;
        public string Name { get { return _name; } set { if (value == null || value == "") { Console.WriteLine("name can't be null"); } else { _name = value; } } }
        private float _height;
        public float Height { get { return _height; } set { if (value < 0) { Console.WriteLine("height can't be blow zero"); } else { _height = value; } } }
        private float _weight;
        public float Weight { get { return _weight; } set { if (value < 0) { Console.WriteLine("weight can't be blow zero"); } else { _weight = value; } } }
        private string _food;
        public string Food { get { return _food; } set { if (value == null || value == "") { Console.WriteLine("food can't be null"); } else { _name = value; } } }

        public Dog() { }

        public Dog(string name)
        {
            _name = name;
        }
        public Dog(string name, float height, float weigt, string food)
        {
            _name = name;
            _height = height;
            _weight = weigt;
            _food = food;
        }

        public void Run()
        {
            Console.WriteLine(_name + " is running");
        }
        public void Play()
        {
            Console.WriteLine(_name + " is playing");
        }
        public void Eat()
        {
            Console.WriteLine(_name + " is eating " + _food);
        }

        public void Size()
        {

            Console.WriteLine("Height: " + _height + " Weight: " + _weight);
        }

        public void ChangeName(string new_name)
        {
            _name = new_name;
        }

        public void ChangeFood(string new_food)
        {
            _name = new_food;
        }
        public string GetData()
        {
            return _name + " ; " + _height + " ; " + _weight + " ; " + _food;
        }










    }
}
