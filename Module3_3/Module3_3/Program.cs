using System;



namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int numberOfElements = InputChecker(Console.ReadLine());
            int[] fibonacciArray = new int[numberOfElements];

            for (int counter = 0; counter < fibonacciArray.Length; counter++)
            {
                if (counter > 1)
                {
                    fibonacciArray[counter] = fibonacciArray[counter - 1] + fibonacciArray[counter - 2];
                    Console.Write(fibonacciArray[counter] + ", ");
                }
                else
                {
                    fibonacciArray[counter] = counter;
                    Console.Write(fibonacciArray[counter] + ", ");
                }
            }

            Console.ReadLine();
        }

        static int InputChecker(string input)
        {
            if (int.TryParse(input, out int parsedInput) && parsedInput > 0)
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
