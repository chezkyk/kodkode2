using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RabanutProject
{
    public partial class Form1 : Form
    {
        private RabnutManager RabnutManager;
        public Form1()
        {
            InitializeComponent();
            XmlDocument datesDocument = MainProject.Main();
            RabnutManager = new RabnutManager(datesDocument);
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            string dayInWeek = null, dayInMonth = null, year = null, month=null;

            switch (comboBoxDayInWeek.Text)
            {
                case ("ראשון"):
                    dayInWeek = "באחד בשבת";
                    break;
                case ("שני"):
                    dayInWeek = "בשני בשבת";
                    break;
                case ("שלישי"):
                    dayInWeek = "בשלישי בשבת";
                    break;
                case ("רביעי"):
                    dayInWeek = "ברביעי בשבת";
                    break;
                case ("חמישי"):
                    dayInWeek = "בחמישי בשבת";
                    break;
                case ("ששי"):
                    dayInWeek = "בששי בשבת";
                    break;

            }
            if (comboBoxDayInMonth.Text == "30")
            {

                switch (comboBoxMonth.Text)
                {
                    case ("תשרי"):
                        month = "מר חשוון";
                        break;
                    case ("מר חשוון"):
                        month = "כסלו";
                        break;
                    case ("כסלו"):
                        month = "טבת";
                        break;
                    case ("טבת"):
                        month = "שבט";
                        break;
                    case ("שבט"):
                        month = "אדר";
                        break;
                    case ("אדר"):
                        month = "ניסן";
                        break;
                    case ("ניסן"):
                        month = "אייר";
                        break;
                    case ("אייר"):
                        month = "סיון";
                        break;
                    case ("סיון"):
                        month = "תמוז";
                        break;
                    case ("תמוז"):
                        month = "אב";
                        break;
                    case ("אב"):
                        month = "אלול";
                        break;
                    case ("אלול"):
                        month = "תשרי";
                        break;
                    case ("אדר הראשון"):
                        month = "אדר השני";
                        break;
                    case ("אדר השני"):
                        month = "ניסן";
                        break;

                }
            }
            switch (comboBoxDayInMonth.Text)
            {
                case ("1"):
                    dayInMonth = "יום אחד לירח";
                    break;
                case ("2"):
                    dayInMonth = "שני ימים לירח";
                    break;
                case ("3"):
                    dayInMonth = "שלשה ימים לירח";
                    break;
                case ("4"):
                    dayInMonth = "ארבעה ימים לירח";
                    break;
                case ("5"):
                    dayInMonth = "חמשה ימים לירח";
                    break;
                case ("6"):
                    dayInMonth = "ששה ימים לירח";
                    break;
                case ("7"):
                    dayInMonth = "שבעה ימים לירח";
                    break;
                case ("8"):
                    dayInMonth = "שמנה ימים לירח";
                    break;
                case ("9"):
                    dayInMonth = "תשעה ימים לירח";
                    break;
                case ("10"):
                    dayInMonth = "עשרה ימים לירח";
                    break;
                case ("11"):
                    dayInMonth = "אחד עשר יום לירח";
                    break;
                case ("12"):
                    dayInMonth = "שנים עשר יום לירח";
                    break;
                case ("13"):
                    dayInMonth = "שלשה עשר יום לירח";
                    break;
                case ("14"):
                    dayInMonth = "ארבעה עשר יום לירח";
                    break;
                case ("15"):
                    dayInMonth = "חמשה עשר יום לירח";
                    break;
                case ("16"):
                    dayInMonth = "ששה עשר יום לירח";
                    break;
                case ("17"):
                    dayInMonth = "שבעה עשר יום לירח";
                    break;
                case ("18"):
                    dayInMonth = "שמנה עשר יום";
                    break;
                case ("19"):
                    dayInMonth = "תשעה עשר יום לירח";
                    break;
                case ("20"):
                    dayInMonth = "עשרים יום לירח";
                    break;
                case ("21"):
                    dayInMonth = "אחד ועשרים יום לירח";
                    break;
                case ("22"):
                    dayInMonth = "שנים ועשרים יום לירח";
                    break;
                case ("23"):
                    dayInMonth = "שלשה ועשרים יום לירח";
                    break;
                case ("24"):
                    dayInMonth = "ארבעה ועשרים יום לירח";
                    break;
                case ("25"):
                    dayInMonth = "חמשה ועשרים יום לירח";
                    break;
                case ("26"):
                    dayInMonth = "ששה ועשרים יום לירח";
                    break;
                case ("27"):
                    dayInMonth = "שבעה ועשרים יום לירח";
                    break;
                case ("28"):
                    dayInMonth = "שמנה ועשרים יום לירח";
                    break;
                case ("29"):
                    dayInMonth = "תשעה ועשרים יום לירח";
                    break;
                case ("30"):
                    dayInMonth = $"יום שלשים לחודש {comboBoxMonth.Text} שהוא ראש חודש {month}";
                    break;



            }
            switch(comboBoxYear.Text)
            {
                case ("תשפ''ד"):
                    year = "ושמנים וארבע";
                    break;
                case ("תשפ''ה"):
                    year = "ושמנים וחמש";
                    break;
                case ("תשפ''ו"):
                    year = "ושמנים ושש";
                    break;
                case ("תשפ''ז"):
                    year = "ושמנים ושבע";
                    break;
                case ("תשפ''ח"):
                    year = "ושמנים ושמנה";
                    break;
                case ("תשפ''ט"):
                    year = "ושמנים ותשע";
                    break;
                case ("תש''צ"):
                    year = "ותשעים";
                    break;
                case ("תשצ''א"):
                    year = "ותשעים ואחת";
                    break;
                case ("תשצ''ב"):
                    year = "ותשעים ושנים";
                    break;
                case ("תשצ''ג"):
                    year = "ותשעים ושלש";
                    break;
                    
            }
            

            List<string> dates = new List<string>()
            {
                comboBoxDayInWeek.Text,
                comboBoxDayInMonth.Text,
                comboBoxMonth.Text,
                comboBoxYear.Text,
                $"{dayInWeek} {dayInMonth} {comboBoxMonth.Text} שנת חמשת אלפים {year} לבריאת העולם ",
            };
            RabnutManager.AddDate(dates);
            lblShowDate.Text = $"{dayInWeek} {dayInMonth} {comboBoxMonth.Text} שנת חמשת אלפים {year} לבריאת העולם ";
        }
    }
}
