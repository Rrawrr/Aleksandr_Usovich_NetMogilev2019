using System;

namespace Module4_4
{
    class Program
    {
        static int[] array;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            EnterNumbers();
            EnterRadius();
            EnterArray();

            Console.ReadLine();
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

            var tuple = PlusTen(intA,intB,intC);
            
            Console.WriteLine("Numbers are: a = " + tuple.intA + ", b = " + tuple.intB + ", c = " + tuple.intC);
        }

        static (int intA,int intB,int intC) PlusTen(int intA,int intB, int intC)
        {
            var result = (intA,intB,intC);
            result.intA += 10;
            result.intB += 10;
            result.intC += 10;

            return result;
        }

        static void EnterRadius()
        {
            Console.WriteLine("Enter the radius: ");
            int radius = InputChecker(Console.ReadLine());

            var tuple = CicleLength(radius);
            Console.WriteLine("Perimeter equals: " + tuple.perimeter);
            Console.WriteLine("Area equals: " + tuple.area);
        }

        static (double perimeter,double area) CicleLength(int radius)
        {
            var result = (perimeter:0d,area:0d);
            result.perimeter = 2 * 3.14d * radius;
            result.area = 3.14d * radius * radius;

            return result;
        }

        static void EnterArray()
        {
            Console.WriteLine("Enter the length of your array: ");
            CreateArray(InputChecker(Console.ReadLine()));

            Console.WriteLine("Your array is: ");
            ShowArray(array);

            var tuple = OperateArray(array);

            Console.WriteLine("The maximum number is: ");
            Console.WriteLine(tuple.maxNumber);
            Console.WriteLine("The minimum number is: ");
            Console.WriteLine(tuple.minNumber);
            Console.WriteLine("The sum of all numbers is: ");
            Console.WriteLine(tuple.sumNumber);
        }

        static (int maxNumber,int minNumber,int sumNumber) OperateArray(int[] array)
        {
            var result = (maxNumber:0, minNumber:0,sumNumber:0);
            foreach (int number in array)
            {
                if (number > result.maxNumber)
                    result.maxNumber = number;
                if (number < result.minNumber)
                    result.minNumber = number;
                result.sumNumber += number;
            }
            return result;
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
