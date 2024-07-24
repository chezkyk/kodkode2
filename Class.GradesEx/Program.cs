using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class.GradesEx
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
            Student[] students = new Student[4];

            students[0] = new Student("Alice", GradeLevel.Freshman, new int[] { 85, 90, 78 });
            students[1] = new Student("Bob", GradeLevel.Sophomore, new int[] { 88, 92, 80 });
            students[2] = new Student("Charlie", GradeLevel.Junior, new int[] { 95, 94, 93 });
            students[3] = new Student("Diana", GradeLevel.Senior, new int[] { 70, 75, 80 });
            foreach (Student student in students)
            {
                student.DisplayInfo();
            }

        }
    }
}
