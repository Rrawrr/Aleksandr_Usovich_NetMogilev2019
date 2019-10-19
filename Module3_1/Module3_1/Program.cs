using System;


namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;

            Console.WriteLine("Enter the first integer");
            int firstNumber = InputChecker(Console.ReadLine());

            Console.WriteLine("Enter the second integer");
            int secondNumber = InputChecker(Console.ReadLine());

            if (firstNumber / Math.Abs(firstNumber) == secondNumber / Math.Abs(secondNumber))
            {
                for (int counter = 1; counter <= Math.Abs(secondNumber); counter++)
                {
                    totalSum += Math.Abs(firstNumber);
                }
            }
            else
            {
                for (int counter = 1; counter <= Math.Abs(secondNumber); counter++)
                {
                    totalSum -= Math.Abs(firstNumber);
                }
            }

            Console.WriteLine("Total sum equals: " + totalSum);
            Console.ReadLine();
        }

        static int InputChecker(string input)
        {
            if (int.TryParse(input, out int parsedInput))
            {
                return parsedInput;
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
