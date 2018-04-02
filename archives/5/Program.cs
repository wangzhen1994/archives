using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?*/

            int min = 1;
            int max = 20;

            int num = 1;

            while (true)
            {
                bool b = true;
                for (int i = min; i <= max; i++)
                {
                    b &= num % i == 0;
                }
                if (b)
                {
                    break;
                }
                else
                {
                    num++;
                    continue;
                }
            }
            Console.WriteLine(num);
            Console.ReadKey();

        }
    }
}
