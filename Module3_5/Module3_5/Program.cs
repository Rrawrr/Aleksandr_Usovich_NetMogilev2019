using System;


namespace Module3_5
{
    class Program
    {
        static string input;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            input = InputChecker(Console.ReadLine());

            Console.WriteLine("Enter the number to exclude");
            string numberToExclude = NumberChecker(Console.ReadLine());

            Excluder(numberToExclude);
            Console.ReadLine();
        }

        static void Excluder(string numberToExclude)
        {
            if (input.Contains(numberToExclude))
            {
                Console.WriteLine(input.Replace(numberToExclude, ""));
            }
            else
            {
                Console.WriteLine("Number to exclude not found");
                Excluder(NumberChecker(Console.ReadLine()));
            }
           
        }

        static string NumberChecker(string input)
        {
            if (int.TryParse(input, out int parsedInput) && parsedInput >= 0 && parsedInput <= 9)
            {
                return parsedInput.ToString();
            }
            else
            {
                Console.WriteLine("Enter the correct data!");
                string newInput = Console.ReadLine();
                return InputChecker(newInput);
            }
        }

        static string InputChecker(string input)
        {
            if (int.TryParse(input, out int parsedInput) && parsedInput > 0)
            {
                return parsedInput.ToString();
            }
            else
            {
                Console.WriteLine("Enter the correct data!");
                string newInput = Console.ReadLine();
                return InputChecker(newInput);
            }
        }
    }
}
