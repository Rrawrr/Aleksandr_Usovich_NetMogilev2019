using System;

namespace Module4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int arrayLength = InputChecker(Console.ReadLine());
            int[] numbers = RandomNumbers(arrayLength);

            Console.WriteLine("Press Enter to add 5 to each number");
            Console.ReadLine();
            IncreaseNumbers(numbers);
        }

        static void IncreaseNumbers(int[] inputArray)
        {
            for (int counter = 0; counter < inputArray.Length; counter++)
            {
                Console.Write((inputArray[counter] += 5)+ " ");
            }
            Console.ReadLine();
        }

        static int[] RandomNumbers(int arrayLength)
        {
            int[] numbers = new int[arrayLength];
            Random rnd = new Random();

            for (int counter = 0; counter < arrayLength; counter++)
            {
                numbers[counter] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Your array is:");
            Console.WriteLine(string.Join(" ", numbers));

            return numbers;
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
