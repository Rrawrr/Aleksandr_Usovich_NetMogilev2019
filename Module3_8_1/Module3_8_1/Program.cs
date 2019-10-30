using System;


namespace Module3_8_1
{
    class Program
    {

        static double Function(double x)
        {
            return Math.Pow(x, 3) - 8;
        }
        static void Main(string[] args)
        {
            double iteration = 0, functionStart, functionEnd, functionIteration;
            double epsilon = 0.001;
            int divisionsCounter = 0;

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

            if (Math.Abs(functionStart) < epsilon)
            {
                Console.WriteLine("Found solution x = {0}, by N = {1} divisions!", start, divisionsCounter);
                Console.ReadLine();
            }

            if (Math.Abs(functionEnd) < epsilon)
            {
                Console.WriteLine("Found solution x = {0}, by N = {1} divisions!", end, divisionsCounter);
                Console.ReadLine();
            }

            do
            {
                iteration = start + (end - start)/2;
                functionIteration = Function(iteration);
                divisionsCounter++;

                if (Math.Abs(functionIteration) < epsilon)
                    break;
                if (functionStart * functionIteration < 0)
                    end = iteration;
                else
                    start = iteration;
            }
            while (Math.Abs(start - end) > epsilon);

            Console.WriteLine("Found solution x = {0}, by N = {1} divisions!", iteration, divisionsCounter);
            Console.ReadLine();
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
