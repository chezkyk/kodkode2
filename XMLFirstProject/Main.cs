﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLFirstProject
{
    public class XMLFirstProject
    {
        public static XmlDocument Main()
        {
            string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Employees.xml");
            //Console.WriteLine("Project Directory: " + pathString);
            // 1.2 Check if file exists
            if (File.Exists(pathString))
            {
                // 1.3 Create a new instance of type XmlDocument
                XmlDocument xmlDoc = new XmlDocument();
                // 1.4 Try and load the XML content into the XmlDocument object
                xmlDoc.Load(pathString);
                return xmlDoc;
            }
            else
            {
                Console.WriteLine("File not found");
            }
            return null;
        }
    }
}
