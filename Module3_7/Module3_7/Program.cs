using System;


namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int arrayLength = InputChecker(Console.ReadLine());

            RandomNumbers(arrayLength);
        }

        static void NumbersComparer(int[] inputArray)
        {
            for (int counter = 0; counter < inputArray.Length -1; counter++)
            {
                if (inputArray[counter + 1] > inputArray[counter])
                {
                    Console.Write(inputArray[counter+1]+" ");
                }
            }

            Console.ReadLine();
        }

        static void RandomNumbers(int arrayLength)
        {
            int[] numbers = new int[arrayLength];
            Random rnd = new Random();

            for (int counter = 0; counter < arrayLength; counter++)
            {
                numbers[counter] = rnd.Next(-100, 100);
            }

            Console.WriteLine("Your array is:");
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine("Press Enter to compare numbers");
            Console.ReadLine();
            NumbersComparer(numbers);
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
