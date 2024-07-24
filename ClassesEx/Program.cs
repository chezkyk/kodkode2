using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesEx
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

            Car[] carsArr = new Car[3];
            carsArr[0] = new Car(ColorEnum.Blue);
            carsArr[1] = new Car(ColorEnum.Red);
            carsArr[2] = new Car(ColorEnum.Green);
            foreach (Car car in carsArr)
            {
                Console.WriteLine(car.DisplayColor());
            }
        }
    }
}
