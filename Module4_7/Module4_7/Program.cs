using System;


namespace Module4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int arrayLength = InputChecker(Console.ReadLine());
            int[] inputArray = RandomNumbers(arrayLength);

            Console.WriteLine("Enter the direction of sorting: + for increasing - for decreasing");
            bool direction = DirectionChecker(Console.ReadLine());

            Console.WriteLine("Sorted array is: ");
            SortArray(inputArray, direction);

            Console.WriteLine(string.Join(" ", inputArray));
            Console.ReadLine();
        }

        static void SortArray(int[] inputArray,bool direction)
        {
            if (direction)
                Array.Sort(inputArray);
            if (!direction)
            {
                Array.Sort(inputArray);
                Array.Reverse(inputArray);
            }
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

        static bool DirectionChecker(string direction)
        {
            switch (direction)
            {
                case "+":
                    return true;
                case "-":
                    return false;
                default:
                    Console.WriteLine("Enter the correct data! +/-");
                    string newInput = Console.ReadLine();
                    return DirectionChecker(newInput);
            }
                
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
