using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.GradesEx
{
    internal class Student
    {
        private string _name;
        private GradeLevel _grade;
        private int[] _scores;
        public Student(string name, GradeLevel grade, int[] scores)
        {
            _name = name;
            _grade = grade;
            _scores = scores;
        }

        public void DisplayInfo()
        {
            string gradeString;
            switch (_grade)
            {
                case GradeLevel.Freshman:
                    gradeString = "Freshman";
                    break;
                case GradeLevel.Sophomore:
                    gradeString = "Sophomore";
                    break;
                case GradeLevel.Junior:
                    gradeString = "Junior";
                    break;
                case GradeLevel.Senior:
                    gradeString = "Senior";
                    break;
                default:
                    gradeString = "Unknown grade level";
                    break;
            }

            float scoreAvg = 0;
            int count = 0;
            foreach (var score in _scores)
            {
                scoreAvg += score;
                count++;
            }
            Console.WriteLine("name is " + _name);
            Console.WriteLine("grade level is " + gradeString);
            Console.WriteLine("avg scors is " + scoreAvg / count);
            Console.WriteLine("****************************************************");

        }
    }
}
