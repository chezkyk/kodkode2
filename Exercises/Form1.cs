using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Exercises
{
    public partial class Form1 : Form
    {
        //string[] names = { "yechezkel", "dovi", "gad" };
        private string[] names = new string[10];
        int i = 10;
        //
        
        //

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            label1.Text = "Yechezkel Kofman";
            int[] ages = new int[10];
            ages[0] = 5;
            Console.WriteLine(ages[3]);

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {


            //names[0] = "yechezkel";
            //names[1] = "dovi";
            //names[2] = "gad";
            //label2.Text = names[0] + " " + names[1] + " " + names[2];
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);


            //loops
            // for
            for (int i = 0; i < names.Length; i++)
            {
                label2.Text += names[i] + " ";
            }

            // foreach
            Console.WriteLine("foreach");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        private void txtAddName_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Student[] studentsArr = new Student[25];
            studentsArr[0] = new Student();
            studentsArr[0].FirstName = "yechezkel";
            studentsArr[0].LastName = "kofman";

            Console.WriteLine(studentsArr[0].FirstName);

            Student student1 = new Student("dovi", "chon");
            studentsArr[1] = student1;

            Console.WriteLine(studentsArr[1].FirstName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            float y;
            string z;
            x = 5;
            y = 6.666f;
            z = "y";
            Console.WriteLine(x + y);
            Console.WriteLine((x + y).GetType());
            Console.WriteLine(x + z);
            Console.WriteLine((x + z).GetType());
            Console.WriteLine(y + x);
            Console.WriteLine((y + x).GetType());
            Console.WriteLine(y + z);
            Console.WriteLine((y + z).GetType());
            Console.WriteLine(z + x);
            Console.WriteLine((z + x).GetType());
            Console.WriteLine(z + y);
            Console.WriteLine((z + y).GetType());
            Console.WriteLine(x + x);
            Console.WriteLine((x + x).GetType());
            Console.WriteLine(y + y);
            Console.WriteLine((y + y).GetType());
            Console.WriteLine(z + z);
            Console.WriteLine((z + z).GetType());
            Console.WriteLine(x + y + z);
            Console.WriteLine((x + y + z).GetType());
            byte a = 1;
            Console.WriteLine((a).GetType());
            bool b = true;
            Console.WriteLine(b + z);
            Console.WriteLine((b + z).GetType());
            //Console.WriteLine(b + y);
            //Console.WriteLine((b + y).GetType());
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            // אתחול עם בנאי ריק
            Dog dogy1 = new Dog();
            dogy1.Name = "Yechezkel";
            dogy1.Height = 1.8f;
            dogy1.Weight = 35f;
            dogy1.Food = "beef";
            // אתחול עם בנאי מלא
            Dog dogy2 = new Dog("kofman", 1.5f, 48f, "ice cream");

            //אתחול עם בנאי חלקי 
            Dog dogy3 = new Dog("dovi");
            dogy3.Height = 2.2f;
            dogy3.Weight = 55.5f;
            dogy3.Food = "eggs";

            // הדפסת הכלב הראשון
            Console.WriteLine("print dogy 1");
            Console.WriteLine(dogy1.Name);
            Console.WriteLine(dogy1.Height);
            Console.WriteLine(dogy1.Weight);
            Console.WriteLine(dogy1.Food);
            dogy1.Run();
            dogy1.Play();
            dogy1.Eat();
            dogy1.Size();
            dogy1.ChangeName("gadi");
            dogy1.ChangeFood("banana");
            dogy1.Eat();
            // הדפסת הכלב השני
            Console.WriteLine("print dogy 2");
            Console.WriteLine(dogy2.Name);
            Console.WriteLine(dogy2.Height);
            Console.WriteLine(dogy2.Weight);
            Console.WriteLine(dogy2.Food);
            dogy2.Run();
            dogy2.Play();
            dogy2.Eat();
            dogy2.Size();
            // הדפסת הכלב השלישי
            Console.WriteLine("print dogy 3");
            Console.WriteLine(dogy3.Name);
            Console.WriteLine(dogy3.Height);
            Console.WriteLine(dogy3.Weight);
            Console.WriteLine(dogy3.Food);
            dogy3.Size();
            dogy3.Run();
            dogy3.Play();
            dogy3.Eat();







        }


        private void btnDog2_Click(object sender, EventArgs e)
        {
            Dog[] dogs = new Dog[3];

            // אתחול עם בנאי ריק
            Dog dogy1 = new Dog();
            dogy1.Name = "yechezkel";
            dogy1.Height = 1.8f;
            dogy1.Weight = 35f;
            dogy1.Food = "beef";
            dogs[0] = dogy1;
            // אתחול עם בנאי מלא
            Dog dogy2 = new Dog("kofman", 1.5f, 48f, "ice cream");
            dogs[1] = dogy2;

            //אתחול עם בנאי חלקי 
            Dog dogy3 = new Dog("dovi");
            dogy3.Height = 2.2f;
            dogy3.Weight = 55.5f;
            dogy3.Food = "eggs";
            dogs[2] = dogy3;

            foreach (Dog dogy in dogs)
            {
                if(dogy != null)
                {
                    Console.WriteLine(dogy.GetData());
                }
                else
                {
                    break;
                }

            }
        }
private void BtnAddName_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            person1.Name = TxtBoxAddName.Text;
            
        }

        private void BtnAddAge_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            person1.Age = int.Parse(TxtBoxAddAge.Text);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            int[] MyArray = { 100, 95, 50, 66, 44, 88 };

           
            Array.Sort(MyArray);

            foreach(int i in MyArray)
            {
                Console.WriteLine(i);
            }


 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] MyArray = { 97, 95, 51, 67, 41, 87 };

            int evenNum = Array.Find(MyArray, n => n % 2 == 0);
            Console.WriteLine(evenNum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] MyArray = { 97, 95, 51, 67, 41, 87 };

            Array.Reverse(MyArray);

            foreach (int i in MyArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
