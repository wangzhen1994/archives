using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

            //Find the sum of all the primes below two million.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> list = new List<long>();

            for (int i = 2; i < 2000000; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                    Console.WriteLine("第{0}个素数是：{1}", list.Count + 1, i);
                }
            }
            Console.WriteLine("和：{0}", list.Sum());

            sw.Stop();
            Console.WriteLine("耗时：{0} ms", sw.ElapsedMilliseconds);

            Console.ReadKey();
        }

        static bool IsPrime(double num)
        {
            if (num == 1)
            {
                return false;
            }
            double sqr = Math.Sqrt(num);

            for (double i = 2; i <= sqr; i++)
            {
                if (Convert.ToInt32(num % i) == 0)
                {
                    return false;
                }

            }

            return true;

        }
    }
}
