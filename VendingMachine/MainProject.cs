using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Vending_machine
{
    internal class MainProject
    {
        private static string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Drinks.xml");
        public MainProject() { }
        public static XmlDocument Main()
        {
            string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Drinks.xml");
            // 1.2 Check if file exists
            if (File.Exists(_pathString))
            {
                // 1.3 Create a new instance of type XmlDocument
                XmlDocument xmlDoc = new XmlDocument();
                // 1.4 Try and load the XML content into the XmlDocument object
                xmlDoc.Load(_pathString);
                return xmlDoc;
            }
            else
            {
                Console.WriteLine("File not found");
            }
            return null;
        }
        public static void Save(XmlDocument xmlDocument)
        {
            xmlDocument.Save(_pathString);
        }
    }
}
