using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar
{
    public class Pillar
    {
        private float _height;
        public float Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height can't be blow zero");
                }
                else
                {

                    _height = value;
                }
            }
        }
        private float _width;
        public float Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width can't be blow zero");
                }
                else
                {

                    _width = value;
                }
            }
        }
        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Location can't be null");
                }
                else
                {

                    _location = value;
                }
            }
        }

        // constructor//"public domain"//"Private domain"//"Carmelit"
        public Pillar() { }
        public string FindLocation()
        {
            string locat = "";

            switch (Location)
            {
                case string l when (Location == "Public domain"):
                    {
                        if (Height < 3 || Height > 9)
                        {
                            locat = "Public domain";
                        }
                        else if (Width == 4)
                        {
                            if (Height > 3 && Height < 9)
                            {
                                locat = "Carmelit";
                            }
                            else if (Height == 10)
                            {
                                locat = "Private domain";
                            }

                        }
                        else if (Width != 4)
                        {
                            if (Height != 10)
                            {
                                locat = "Petur";
                            }
                        }
                        break;
                    }
                case string l when (Location == "Private domain"):
                    {
                        locat = "Private domain";
                        break;
                    }
                case string l when (Location == "Carmelit"):
                    {
                        if (Width == 4)
                        {
                            if (Height != 10)
                            {

                                locat = "Carmelit";
                            }
                            else
                            {
                                locat = "Private domain";
                            }
                        }
                        else if (Width < 4)
                        {
                            if (Height > 10)
                            {
                                locat = "According to the Tur, its status is like a Carmelit; according to Rashi, its status is like a Makom Petur.";
                            }
                        }

                        break;
                    }

            }
            return locat;
        }


    }
}
