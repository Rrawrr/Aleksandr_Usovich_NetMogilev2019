using System;

namespace Module4_5_2
{
    class Program
    {
        enum Months
        {
            January = 31, February = 28, March = 31, April = 30, May = 31, June = 30 , July = 31,
            August = 31, September = 30, October = 31, November = 30,December = 31
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select the month: jan/feb/mar/apr/may/jun/jul/aug/sep/oct/nov/dec");
            int numberOfDays = SelectionChecker(Console.ReadLine());

            Console.WriteLine("The number of days in your month equals: " + numberOfDays);
            Console.ReadLine();

        }

        static int SelectionChecker(string input)
        {
            switch (input)
            {
                case "jan":
                    return (int)Months.January;
                case "feb":
                    return (int)Months.February;
                case "mar":
                    return (int)Months.March;
                case "apr":
                    return (int)Months.April;
                case "may":
                    return (int)Months.May;
                case "jun":
                    return (int)Months.June;
                case "jul":
                    return (int)Months.July;
                case "aug":
                    return (int)Months.August;
                case "sep":
                    return (int)Months.September;
                case "oct":
                    return (int)Months.October;
                case "nov":
                    return (int)Months.November;
                case "dec":
                    return (int)Months.December;
                default:
                    Console.WriteLine("Enter the correct data! jan/feb/mar/apr/may/jun/jul/aug/sep/oct/nov/dec");
                    string newInput = Console.ReadLine();
                    return SelectionChecker(newInput);
            }
        }
    }
}
