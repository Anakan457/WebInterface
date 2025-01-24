using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FunctionForMenu
    {
        private string _path = string.Empty;
        public FunctionForMenu(string path = "D:\\уник\\2024 первый семестр\\Розробка вебзастосунків на базі ASP.NET\\Projects\\ConsoleApp3\\Text\\text.txt")
        {
            _path = path;
        }

        public int LentghTextFromFile()
        {
            int countWords = 0;
            try
            {
                using (StreamReader reader = new StreamReader(_path))
                {
                   // _result = reader.ReadToEnd();
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        countWords += line.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Exception - " + ex);
            }
           return countWords;
        }

        public double MathOperation(string operation, double x, double y)
        {
            switch (operation)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                case "/":
                    if (y == 0) 
                        return 0;
                    return x / y;
                default:
                    Console.WriteLine("incorrect operation");
                    return 0;
            }
        }
    }
}
