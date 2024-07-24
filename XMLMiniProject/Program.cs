
using System.Xml;
using System.Xml.Linq;

namespace XMLMiniProject;
class XMLProj()
{

    public static void Main(string[] args)
    {
        string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Students.xml");
        XmlDocument xmlDoc;

        if (File.Exists(_pathString))
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(_pathString);

        }
        else
        {
            xmlDoc = new XmlDocument();
            XmlNode studentsNode = xmlDoc.CreateElement("Students");
            xmlDoc.AppendChild(studentsNode);
        }

        xmlDoc.Save(_pathString);
        // Create a new student node
        XmlNode studentNode = xmlDoc.CreateElement("Student");

        // Create and append child elements for the student
        XmlNode nameNode = xmlDoc.CreateElement("Name");
        nameNode.InnerText = "John Doe";
        studentNode.AppendChild(nameNode);

        XmlNode ageNode = xmlDoc.CreateElement("Age");
        ageNode.InnerText = "21";
        studentNode.AppendChild(ageNode);

        XmlNode idNode = xmlDoc.CreateElement("ID");
        idNode.InnerText = "12345";
        studentNode.AppendChild(idNode);

        // Get the root element and append the new student
        XmlNode root = xmlDoc.DocumentElement;
        root.AppendChild(studentNode);

        // Save the XML document
        xmlDoc.Save(_pathString);
    }
}


