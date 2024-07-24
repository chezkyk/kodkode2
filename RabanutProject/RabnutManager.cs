using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace RabanutProject
{

    internal class RabnutManager
    {
        private XmlDocument _document;
        public RabnutManager(XmlDocument doc)
        {
            _document = doc;
        }
        private XmlNode GetRoot()
        {
            return _document.GetElementsByTagName("Queries")[0];

        }
        //public void Save()
        //{
        //    MainProject.Save(_document);
        //}
        public void AddDate(List<string> dates)
        {
            XmlElement datesElement = _document.CreateElement("Query");
            List<string> tagsName = new List<string>() { "Day", "DayMonth", "Month", "Year", "Result"};
            Console.WriteLine("langth " + tagsName.Count);
            for (int i = 0; i < tagsName.Count; i++)
            {
                XmlElement child = _document.CreateElement(tagsName[i]);
                child.InnerText = dates[i];
                datesElement.AppendChild(child);
                GetRoot().AppendChild(datesElement);
                Console.WriteLine("i= " + i);
            }
            MainProject.Save(_document);
        }
    }
}
