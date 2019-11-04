using System;


namespace Module4_3
{
    class Program
    {
        static Random rnd = new Random();
        static int[] array;
        
        
        static void Main(string[] args)
        {

            EnterNumbers();
            EnterRadius();
            EnterArray();

            Console.ReadLine();
        }

        static void EnterArray()
        {
            Console.WriteLine("Enter the length of the array: ");
            CreateArray(InputChecker(Console.ReadLine()));

            Console.WriteLine("Your array is: ");
            ShowArray(array);

            int maxNumber, minNumber, sumNumber;
            OperateArray(array, out maxNumber, out minNumber, out sumNumber);

            Console.WriteLine("The maximum number is: " + maxNumber);
            Console.WriteLine("The minimum number is: " + minNumber);
            Console.WriteLine("The sum of all numbers is: " + sumNumber);
        }

        static void OperateArray(int[] array, out int maxNumber, out int minNumber,out int sumNumber)
        {
            maxNumber = 0;
            minNumber = 0;
            sumNumber = 0;
            foreach (int number in array)
            {
                if (number > maxNumber)
                    maxNumber = number;
                if (number < minNumber)
                    minNumber = number;
                sumNumber += number;
            }
        }

        static void EnterRadius()
        {
            Console.WriteLine("Enter the radius: ");
            int radius = InputChecker(Console.ReadLine());
            double perimeter;
            double area;

            CicleLength(radius, out perimeter, out area);
            Console.WriteLine("Perimeter equals: " + perimeter);
            Console.WriteLine("Area equals: " + area);
        }

        static void CicleLength(int radius,out double perimeter,out double area)
        {
            perimeter = 2 * 3.14d * radius;
            area = 3.14d * radius * radius;
        }

        static void EnterNumbers()
        {
            int intA, intB, intC;

            Console.WriteLine("Enter the number a: ");
            intA = InputChecker(Console.ReadLine());

            Console.WriteLine("Enter the number b: ");
            intB = InputChecker(Console.ReadLine());

            Console.WriteLine("Enter the number c: ");
            intC = InputChecker(Console.ReadLine());

            PlusTen(ref intA, ref intB, ref intC);

            Console.WriteLine("Numbers are: a = " + intA + ", b = " + intB + ", c = " + intC);
        }

        static void PlusTen(ref int intA,ref int intB,ref int intC)
        {
            intA += 10;
            intB += 10;
            intC += 10;
        }

        static int[] CreateArray(int length)
        {
            array = new int[length];
            for (int counter = 0; counter < length; counter++)
            {
                array[counter] = rnd.Next(-100, 100);
            }
            return array;
        }

        static void ShowArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine();
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
