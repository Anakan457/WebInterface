namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionForMenu functionForMenu = new FunctionForMenu();
            bool check = false;
            Console.WriteLine("Welcome to my program,");

            while (true)
            {
                Console.WriteLine("choice variant:\n1 - Lentght \"Lorem Ipsum\" text from file(you can write own file)\n" +
                "2 - math operation(+, -, /, *)\n0 - exit");
                if (check)
                {
                    Console.WriteLine("Good bye!");
                    return;
                }
                string? variant  = Console.ReadLine();
                switch (variant)
                {
                    case "1":
                        int count = functionForMenu.LentghTextFromFile();
                        Console.WriteLine(count);
                        continue;
                    case "2":
                        Console.WriteLine("write a math operation\n(+, -, /, *)");
                        string? operation = Console.ReadLine();
                        double fisrtValue = 0;
                        double secondValue = 0;
                        try
                        {
                            Console.WriteLine("First value");
                            fisrtValue = double.Parse(Console.ReadLine());
                            Console.WriteLine("Second value");
                            secondValue= double.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        double result = Math.Round(functionForMenu.MathOperation(operation, fisrtValue, secondValue), 2);
                        Console.WriteLine(result);
                        continue; 
                    case "0":
                        check = true;
                        break;
                    default: Console.WriteLine("Nan operation");
                        continue;

                }
            }
        }
    }
}
