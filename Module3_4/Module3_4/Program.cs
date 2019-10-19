using System;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] outputArray;

            Console.WriteLine("Enter an integer");
            string input = InputChecker(Console.ReadLine());

            outputArray = input.ToCharArray();
            Array.Reverse(outputArray);

            Console.WriteLine(outputArray);
            Console.ReadLine();
            
        }
        

        static string InputChecker(string input)
        {
            if (decimal.TryParse(input, out decimal parsedInput) && parsedInput > 0)
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
