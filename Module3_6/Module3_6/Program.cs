using System;

namespace Module3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int arrayLength = InputChecker(Console.ReadLine());

            RandomNumbers(arrayLength);

        }

        static void SignSwitcher(int[] arrayToSwitch)
        {
            for (int counter = 0; counter < arrayToSwitch.Length; counter++)
            {
                arrayToSwitch[counter] = -arrayToSwitch[counter];
            }
            Console.WriteLine("The switched array is:");
            Console.WriteLine(string.Join(" ", arrayToSwitch));
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
            Console.WriteLine(string.Join(" ",numbers));
            Console.WriteLine("Press Enter to switch the sign of numbers");
            Console.ReadLine();
            SignSwitcher (numbers);
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
