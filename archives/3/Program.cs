using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://projecteuler.net/problem=3

            //13195的主要因素是5,7,13和29。

            //数字600851475143的最大素数是多少？

            long value = 104743;

            Console.WriteLine(GetValue(value));

            Console.ReadKey();
        }

        static long GetValue(long value= 600851475143)
        {
            long i = 2;
            while (true)
            {
                if (value > i)
                {
                    if (value % i == 0)
                    {
                        value = value / i;
                        return GetValue(value);
                    }
                    i++;
                    continue;
                }
                return value;
            }
        }
    }
}
