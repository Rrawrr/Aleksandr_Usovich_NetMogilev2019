using System;


namespace Module4_2
{
    class Program
    {
        static int intA, intB, intC;
        static Random rnd = new Random();
        static int[] arrayA;
        static int[] arrayB;


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number a: ");
            intA = InputChecker(Console.ReadLine());

            Console.WriteLine("Enter the number b: ");
            intB = InputChecker(Console.ReadLine());

            Console.WriteLine("Enter the number c: ");
            intC = InputChecker(Console.ReadLine());

            SumABC();
            SumAB();
            SumDouble();
            SumStrings();
            SumArray();

            Console.ReadLine();
        }

        static void SumArray()
        {
            Console.WriteLine("Enter the lengh of the array A: ");
            arrayA = CreateArray(InputChecker(Console.ReadLine()));
            Console.WriteLine("Array A is: ");
            ShowArray(arrayA);

            Console.WriteLine("Enter the lengh of the array B: ");
            arrayB = CreateArray(InputChecker(Console.ReadLine()));
            Console.WriteLine("Array B is: ");
            ShowArray(arrayB);

            Console.WriteLine("The sum of arrays A and B is: ");
            if (arrayA.Length >= arrayB.Length)
            {
                for (int counter = 0; counter < arrayA.Length; counter++)
                {
                    arrayA[counter] += arrayB[counter];
                }
                ShowArray(arrayA);
            }
            else
            {
                for (int counter = 0; counter < arrayA.Length; counter++)
                {
                    arrayB[counter] += arrayA[counter];
                }
                ShowArray(arrayB);
            }
        }

        static void SumABC()
        {
            Console.WriteLine("The sum of A, B and C is: ");
            Console.WriteLine(intA + intB + intC);
        }

        static void SumAB()
        {
            Console.WriteLine("The sum of A and B is: ");
            Console.WriteLine(intA + intB);
        }

        static void SumDouble()
        {
            Console.WriteLine("Enter the float number A: ");
            double doubleA = InputCheckerDouble(Console.ReadLine());

            Console.WriteLine("Enter the float number B: ");
            double doubleB = InputCheckerDouble(Console.ReadLine());

            Console.WriteLine("Enter the float number C: ");
            double doubleC = InputCheckerDouble(Console.ReadLine());

            Console.WriteLine("The sum of float numbers A,B and C is: ");
            Console.WriteLine(doubleA+doubleB+doubleC);
        }

        static void SumStrings()
        {
            Console.WriteLine("Enter the string A: ");
            string stringA = Console.ReadLine();

            Console.WriteLine("Enter the string B: ");
            string stringB = Console.ReadLine();

            Console.WriteLine("The sum of strings A and B is: ");
            Console.WriteLine(stringA+stringB);
        }

        static int[] CreateArray(int length)
        {
            int[] array = new int[length];
            for (int counter = 0; counter < length; counter++)
            {
                array[counter] = rnd.Next(-100,100);
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

        static double InputCheckerDouble(string input)
        {
            if (double.TryParse(input, out double parsedInput))
            {
                return parsedInput;
            }
            else
            {
                Console.WriteLine("Enter the correct data!");
                string newInput = Console.ReadLine();
                return InputCheckerDouble(newInput);
            }
        }
    }
}
