using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEx
{
    internal class Car
    {
        private ColorEnum _carColor;
        public ColorEnum CarColor
        { get { return _carColor; } set { _carColor = value; } }

        public Car(ColorEnum carColor)
        {
            _carColor = carColor;
        }

        public string DisplayColor()
        {
            return _carColor.ToString();
        }
        
    }
}
