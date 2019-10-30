using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            float a = InputChecker(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            float b = InputChecker(Console.ReadLine());


            Console.WriteLine("Swapped numbers are:");
            Console.WriteLine(b);
            Console.WriteLine(a);

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
            if (float.TryParse(a, out float n))
            {
                return n;
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
