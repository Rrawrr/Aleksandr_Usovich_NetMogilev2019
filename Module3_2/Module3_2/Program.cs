using System;


namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the natural number");
            int naturalNumbers = InputChecker(Console.ReadLine());
            int totalCounter = 0;

            for (int localCounter = 1; totalCounter < naturalNumbers; localCounter++)
            {
                if (localCounter % 2 == 0)
                {
                    Console.Write(localCounter + ", ");
                    totalCounter++;
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
