using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What do you want to calculate?");
            Console.WriteLine("Press 1 for Circle, 2 for Triangle, 3 for Square");
            double selection = InputChecker(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.WriteLine("You have chosen a Circle");
                    Selector();
                    break;
                case 2:
                    Console.WriteLine("You have chosen a Triangle");
                    Selector();
                    break;
                case 3:
                    Console.WriteLine("You have chosen a Square");
                    Selector();
                    break;
                default:
                    Console.WriteLine("You have chosen something wrong");
                    Console.ReadLine();
                    break;
            }

        }

        static void Selector()
        {
            double radius;
            Console.WriteLine("What do you want to calculate?");
            Console.WriteLine("Press 1 for Perimeter, 2 for the Area");
            double selection = InputChecker(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("You have chosen Perimeter");
                    Console.WriteLine("Enter the lenght of the side or radius");
                    radius = InputChecker(Console.ReadLine());
                    Perimeter(radius);
                    break;
                case 2:
                    Console.WriteLine("You have chosen Area");
                    Console.WriteLine("Enter the lenght of the side or radius");
                    radius = InputChecker(Console.ReadLine());
                    Area(radius);
                    break;
                default:
                    Console.WriteLine("You have chosen something wrong");
                    Console.ReadLine();
                    break;
            }

        }

        static void Perimeter(double radius)
        {
            double circlePer = 2 * radius * 3.14;
            Console.WriteLine("Circle perimeter is " + circlePer);

            double trianglePer = 3 * radius;
            Console.WriteLine("Triangle perimeter is " + trianglePer);

            double squarePer = 4 * radius;
            Console.WriteLine("Square perimeter is " + squarePer);
            Console.ReadLine();
        }

        static void Area(double radius)
        {
            double circleArea = radius*radius * 3.14;
            Console.WriteLine("Circle perimeter is " + circleArea);

            double halfPer = 3 * radius / 2;
            double triangleArea = Math.Sqrt(halfPer*(halfPer - radius)*(halfPer - radius)*(halfPer - radius)) ;
            Console.WriteLine("Triangle perimeter is " + triangleArea);

            double squareArea = radius*radius;
            Console.WriteLine("Square perimeter is " + squareArea);
            Console.ReadLine();
        }


        static float InputChecker(string a)
        {
            if (a.Contains(","))
            {
                Console.WriteLine("Separate your float with a dot .");
                string b = Console.ReadLine();
                return InputChecker(b);
            }
            else if (float.TryParse(a, out float n))
            {
                if (n > 0)
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Enter a number more than 0");
                    string b = Console.ReadLine();
                    return InputChecker(b);
                }
            }
            else
            {
                Console.WriteLine("Enter the correct data!");
                string b = Console.ReadLine();
                return InputChecker(b);
            }
        }
    }
}
