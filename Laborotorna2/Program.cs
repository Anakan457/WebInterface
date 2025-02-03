using System.Collections; //.NET STANDARD
using System.Drawing;
using System.IO;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Laborotorna4
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"name - {Name}, age - {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //.NET Standard
            ArrayList arrayListName = ["Ivan"];
            arrayListName.Add("Oleh");
            arrayListName.Add("Svetlana");
            arrayListName.Add(4);
            Console.WriteLine("Item from arrayListName");
            ShowArray(arrayListName);
            arrayListName[2] = "2";
            ShowArray(arrayListName);
            arrayListName.Clear();
            ShowArray(arrayListName);
            Console.WriteLine("Hello, World!");
            //.NET STANDARD
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("text from file");
            using (StreamReader sr = new StreamReader("D:\\уник\\2025 весна\\Розробка адаптивних web-інтерфейсів\\Projects\\Laborotorna4\\File\\infoAboutMe.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////");
            //.NER Framework
            using (Bitmap bitmap = new Bitmap(300, 300))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);
                    graphics.DrawRectangle(new Pen(Color.Black, 2), 50, 50, 200, 200);
                    graphics.FillRectangle(new SolidBrush(Color.Black), 100, 100, 200, 200);
                }
                bitmap.Save("picture.png", System.Drawing.Imaging.ImageFormat.Png);
            }

            Console.WriteLine("picture saving");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////");
            //.NET STANDARD
            Person person = new Person("Ivan", 19);
            string json = JsonSerializer.Serialize(person);
            Console.WriteLine(json);

            Person desearalize = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(desearalize);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////");
            //.NET FRAMEWORK
            string[] people = { "Tom", "Bob", "Sam", "Tim", "tomas", "Bill" };

            var selectedPeople = people.Where(p => p.ToUpper().StartsWith("T"));
            foreach (string person1 in selectedPeople)
                Console.WriteLine(person1);

        }

        public static void ShowArray(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
