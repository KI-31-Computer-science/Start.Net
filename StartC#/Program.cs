namespace StartC_
{
    internal class Program
    {
        static int Main(string[] args)
        {
            int a, b;
            int choise;

            Console.Write("Enter a: ");
            a = GetNumber();

            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine();
            choise = GetNumber(1, 4);

            while (true)
            {
                Console.Write("Enter b: ");
                b = GetNumber();

                if (choise != 4)
                {
                    break;
                }

                if (b == 0)
                {
                    Console.WriteLine("Division by zero!");
                    Console.WriteLine();
                    continue;
                }

                break;
            }

            switch (choise)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case 4:
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    return -1;
            }

            return 0;
        }

        static int GetNumber(int? from = null, int? to = null)
        {
            int result;
            while (true) 
            {
                Console.Write("Enter a number: ");
                string? userInput = Console.ReadLine();

                try
                {
                    result = Convert.ToInt32(userInput);
                }
                catch(FormatException) 
                {
                    Console.WriteLine("\nIs not a number!\n");
                    continue;
                }

                if (from.HasValue && to.HasValue)
                {
                    if (result < from || result > to)
                    {
                        Console.WriteLine("\nThis number less than from value or greater than to!\n");
                        continue;
                    }
                }

                break;
            }

            return result;
        }
    }
}