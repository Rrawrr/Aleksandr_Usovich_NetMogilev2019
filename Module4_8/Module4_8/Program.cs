using System;

namespace Module4_8
{
    class Program
    {
        static double iteration = 0, functionStart, functionEnd, functionIteration;
        static readonly double epsilon = 0.001;
        static int divisionsCounter = 0;

        static double Function(double x)
        {
            return Math.Pow(x, 3) - 8;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Your function is: f(x) = x ^ 3 - 8");
            Console.WriteLine();

            Console.Write("Enter the start of the segment: ");
            double start = InputChecker(Console.ReadLine());

            Console.Write("Enter the end of the segment: ");
            double end = InputChecker(Console.ReadLine());

            functionStart = Function(start);
            functionEnd = Function(end);

            if (functionStart * functionEnd > 0)
            {
                Console.WriteLine("There is no solution on the entered segment");
                Console.ReadLine();
            }
            else if (Math.Abs(functionStart) < epsilon)
            {
                Console.WriteLine("Found solution x = {0}, by N = {1} divisions!", start, divisionsCounter);
                Console.ReadLine();
            }
            else if (Math.Abs(functionEnd) < epsilon)
            {
                Console.WriteLine("Found solution x = {0}, by N = {1} divisions!", end, divisionsCounter);
                Console.ReadLine();
            }

            BisectionMethod(start,end);
            Console.WriteLine("Found solution x = {0}, by N = {1} divisions!", iteration, divisionsCounter);
            Console.ReadLine();

        }

        static (double,int) BisectionMethod(double start,double end)
        {

            iteration = (start + end) / 2;
            functionIteration = Function(iteration);

            if (Math.Abs(functionIteration) <= epsilon)
            {
                return (iteration, divisionsCounter);
            }
            else
            {
                if (functionStart * functionIteration < 0)
                {
                    end = iteration;
                    divisionsCounter++;
                }
                if (functionEnd * functionIteration < 0)
                {
                    start = iteration;
                    divisionsCounter++;
                }
                return BisectionMethod(start, end);
            }
        }

        static double InputChecker(string input)
        {
            if (double.TryParse(input, out double parsedInput))
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
