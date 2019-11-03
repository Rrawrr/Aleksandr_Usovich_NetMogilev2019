using System;


namespace Module4_1
{
    class Program
    {
        static int[] array = new int[10];
        static int maxNumber;
        static int minNumber;

        static void Main(string[] args)
        {
            NewArray();
            MaxElement();
            MinElement();
            SumElement();
            DifferenceElement();
            ChangeArray();

            Console.ReadLine();
        }

        static void NewArray()
        {
            Console.WriteLine("Your array is: ");
            Random rnd = new Random();
            for (int counter = 0; counter < array.Length; counter++)
            {
                array[counter] = rnd.Next(-100,100);
            }

            ShowArray();
            Console.WriteLine();
        }

        static void ShowArray()
        {
            foreach (int number in array)
            {
                Console.Write(number + ", ");
            }
        }

        static void MaxElement()
        {
            Console.WriteLine("Maximum element is: ");
            maxNumber = array[1];
            foreach (int number in array)
            {
                if (number > maxNumber)
                    maxNumber = number;
            }
            Console.WriteLine(maxNumber);
        }

        static void MinElement()
        {
            Console.WriteLine("Minimum element is: ");
            minNumber = array[1];
            foreach (int number in array)
            {
                if (number < minNumber)
                    minNumber = number;
            }
            Console.WriteLine(minNumber);
        }

        static void SumElement()
        {
            Console.WriteLine("Sum of all elements is: ");
            int totalNumber = 0;
            foreach (int number in array)
            {
                totalNumber += number;
            }
            Console.WriteLine(totalNumber);
        }

        static void DifferenceElement()
        {
            Console.WriteLine("Difference of max and min number is: ");
            int result = maxNumber - minNumber;
            Console.WriteLine(result);
        }

        static void ChangeArray()
        {
            Console.WriteLine("Changed array is: ");
            for (int counter = 0; counter < array.Length; counter++)
            {
                if (counter % 2 == 0)
                    array[counter] += maxNumber;
                else
                    array[counter] -= minNumber;
            }

            ShowArray();
        }
                      
    }
}
