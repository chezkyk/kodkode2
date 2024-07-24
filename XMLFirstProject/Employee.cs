using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLFirstProject
{
    internal class Employee
    {
        public XmlDocument XmlDocument;
        public Employee(XmlDocument xmlDocument)
        {
            XmlDocument = xmlDocument;
        }

        public void GetAllEmployee(XmlNodeList? xmlNodeList)
        {
            if(xmlNodeList == null)
            {
                xmlNodeList = XmlDocument.SelectNodes("/Employees/Employee");
            }
            foreach(XmlNode children in xmlNodeList)
            {
                if (children.Attributes != null)
                {
                    
                    foreach (XmlAttribute attribute in children.Attributes)
                    {
                        Console.WriteLine(attribute.Name + ": " + attribute.Value);
                    }
                }
                if (children.ChildNodes != null)
                {
                    GetAllEmployee(children.ChildNodes);
                }

            }
        }
        public void GetOneEmployeeByID(string id)
        {
            XmlNode employee = XmlDocument.SelectSingleNode($"/Employees/Employee[@id= {id}]");
            if (employee == null) return;
            if (employee.Attributes != null)
            {
                foreach (XmlAttribute attr in employee.Attributes)
                {
                    Console.WriteLine(attr.Name + ": " + attr.Value);
                }
                if (employee.ChildNodes != null)
                {
                    GetAllEmployee(employee.ChildNodes);
                }
            }
        }










    }
}
