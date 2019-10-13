using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int c = 500;
            int sumPersent;

            Console.WriteLine("Enter the number of companies");
            int n = InputChecker(Console.ReadLine());
            
            Console.WriteLine("Enter the tax percent");
            int m = InputChecker(Console.ReadLine());

            sumPersent = n * m * c / 100;

            Console.WriteLine("Total tax equals: " + sumPersent);
            Console.ReadLine();

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
