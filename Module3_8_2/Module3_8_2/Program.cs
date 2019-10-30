using System;

namespace Module3_8_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of your array:");
            int size = InputChecker(Console.ReadLine());
            int[,] array = new int[size, size];
            int currentNumber = 1;

            for (int offset = 0; offset < size - 2; offset++)
            {

                for (int columnCounter = offset; columnCounter < size - offset; columnCounter++)
                {
                    array[offset, columnCounter] = currentNumber;
                    currentNumber++;
                }

                for (int rowCounter = 1 + offset; rowCounter < size - offset; rowCounter++)
                {
                    array[rowCounter, size - (1 + offset)] = currentNumber;
                    currentNumber++;
                }

                for (int columnCounter = size - (2 + offset); columnCounter >= offset; columnCounter--)
                {
                    array[size - (1 + offset), columnCounter] = currentNumber;
                    currentNumber++;
                }

                for (int rowCounter = size - (2 + offset); rowCounter > offset; rowCounter--)
                {
                    array[rowCounter, offset] = currentNumber;
                    currentNumber++;
                }
            }

            ShowArray(array, size);

        }

        static void ShowArray(int[,] array, int size)
        {
            for (int rowCounter = 0; rowCounter < size; rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < size; columnCounter++)
                {
                    Console.Write(string.Format("{0,3}", array[rowCounter, columnCounter]));

                }
                Console.WriteLine();
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
