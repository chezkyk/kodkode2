using System.Xml;
using XMLFirstProject;

XmlDocument XmlDocument = XMLFirstProject.XMLFirstProject.Main();

Employee employee = new Employee(XmlDocument);

employee.GetAllEmployee(null);
employee.GetOneEmployeeByID("2");

