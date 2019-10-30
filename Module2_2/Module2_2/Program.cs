using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = InputChecker(Console.ReadLine());

            if (age % 2 == 0 && age >= 18)
            {
                Console.WriteLine("Happy legal age:)");
                Console.ReadLine();
            }
            else if (age % 2 != 0 && age >= 13 && age < 18)
            {
                Console.WriteLine("Happy high school!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No special condition for your age");
                Console.ReadLine();
            }
        }

        static int InputChecker(string a)
        {
            if (Int32.TryParse(a, out int n))
            {
                if (n > 0)
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
            else
            {
                Console.WriteLine("Enter the correct data!");
                string b = Console.ReadLine();
                return InputChecker(b);
            }
        }
    }
}
