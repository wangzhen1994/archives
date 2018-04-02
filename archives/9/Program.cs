using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

            //a2 + b2 = c2
            //For example, 32 + 42 = 9 + 16 = 25 = 52.

            //There exists exactly one Pythagorean triplet for which a +b + c = 1000.
            //Find the product abc.


            for (int a = 1; a < 999; a++)
            {
                for (int b = 1; b < 999; b++)
                {
                    if (a * a + b * b == c(a, b) * c(a, b))
                    {
                        Console.WriteLine("a:{0}, b:{1}, c:{2}, abc:{3}", a, b, c(a, b), a * b * c(a, b));
                        Console.ReadKey();
                        return;
                    }
                }
            }
            Console.WriteLine("未找到");

            Console.ReadKey();
        }

        static int c(int a, int b)
        {
            return 1000 - a - b;
        }
    }
}
