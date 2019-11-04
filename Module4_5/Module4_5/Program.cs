using System;

namespace Module4_5
{
    class Program
    {
        enum Operation
        {
            Sum,
            Difference,
            Multiply,
            Divide
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number A: ");
            double doubleA = InputChecker(Console.ReadLine());

            Console.WriteLine("Enter the number B: ");
            double doubleB = InputChecker(Console.ReadLine());

            Console.WriteLine("Select the operation: sum/diff/mult/div");
            Operation operation = SelectionChecker(Console.ReadLine());

            Console.WriteLine("The result of the operation equals: " + Operations(doubleA, doubleB, operation));
            Console.ReadLine();
        }

        static double Operations (double doubleA, double doubleB, Operation operation)
        {
            double result = 0d;

            switch (operation)
            {
                case Operation.Sum:
                    result = doubleA + doubleB;
                    break;
                case Operation.Difference:
                    result = doubleA - doubleB;
                    break;
                case Operation.Multiply:
                    result = doubleA * doubleB;
                    break;
                case Operation.Divide:
                    result = doubleA / doubleB;
                    break;
            }
            return result;

        }

        static Operation SelectionChecker(string input)
        {
            switch (input)
            {
                case "sum":
                    return Operation.Sum;
                case "diff":
                    return Operation.Difference;
                case "mult":
                    return Operation.Multiply;
                case "div":
                    return Operation.Divide;
                default:
                    Console.WriteLine("Enter the correct data! sum/diff/mult/div ");
                    string newInput = Console.ReadLine();
                    return SelectionChecker(newInput);
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
