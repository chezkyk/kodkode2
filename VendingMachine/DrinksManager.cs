using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace Vending_machine
{
    internal class DrinksManager
    {
        private XmlDocument _document;
        public DrinksManager(XmlDocument doc)
        {
            _document = doc;
        }

        public List<List<string>> GetDrinksData()
        {
            List<List<string>> allDrinks = new List<List<string>>();
            XmlNodeList DrinksNodes = _document.SelectNodes("/drinks/drink");
            if (DrinksNodes != null)
            {

                foreach (XmlNode drink in DrinksNodes)
                {
                    List<string> DrinksList = new List<string>();
                    if (drink.ChildNodes != null)
                    {

                        foreach (XmlNode drinkData in drink.ChildNodes)
                        {
                            DrinksList.Add(drinkData.InnerText);
                        }
                    }
                    allDrinks.Add(DrinksList);
                }
            }
            return allDrinks;
        }
        private XmlNode GetRoot()
        {
            return _document.GetElementsByTagName("drinks")[0];

        }
        public void AddDrink(List<string> drinks)
        {
            XmlElement drinksElement = _document.CreateElement("drink");
            List<string> tagsName = new List<string>() { "name", "coffee", "sugar", "milk", "cocoa", "price" };
            for (int i = 0; i < tagsName.Count; i++)
            {
                XmlElement child = _document.CreateElement(tagsName[i]);
                child.InnerText = drinks[i];
                drinksElement.AppendChild(child);
                GetRoot().AppendChild(drinksElement);
            }
        }
        public void Save()
        {
            MainProject.Save(_document);
        }
        public void UpdateDrink(List<string> drinks)
        {
            XmlNodeList drinksList = _document.GetElementsByTagName("name");
            if (drinksList == null) { return; }
            foreach (XmlNode drink in drinksList)
            {
                if (drink.InnerText == drinks[0])
                {
                    int i = 0;
                    foreach (XmlNode child in drink.ParentNode)
                    {
                        child.InnerText = drinks[i++];
                    }
                }
            }
        }
        public List<string> GetDrinksByName(string name)
        {
            List<string> list = null;
            XmlNodeList drinksList = _document.GetElementsByTagName("name");
            if (drinksList == null)
            {
                return null;
            }
            foreach (XmlNode drink in drinksList)
            {
                if (drink.InnerText == name)
                {
                    list = GetAllData(drink.ParentNode);
                    break;
                }
            }
            return list;
        }
        private List<string> GetAllData(XmlNode drink)
        {
            List<string> list = new List<string>();
            foreach (XmlNode child in drink.ChildNodes)
            {
                list.Add(child.InnerText);
            }
            return list;
        }
        public void DeleteDrink(string drinkName)
        {
            XmlNodeList drinksList = _document.GetElementsByTagName("name");
            if (drinksList == null) { return; }

            foreach (XmlNode drink in drinksList)
            {
                if (drink.InnerText == drinkName)
                {
                    
                    GetRoot().RemoveChild(drink.ParentNode);
                    break;
                }
            }

            
            Save();
        }
    }
}
