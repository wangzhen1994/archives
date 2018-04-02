using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

            //What is the 10 001st prime number?
            long i = 1;

            long j = 2;

            while (true)
            {
                if (i <= 10001)
                {
                    if (IsPrime(j))
                    {
                        Console.WriteLine("第{0}个素数是：{1}", i, j);
                        i++;
                    }
                    j++;
                    
                    continue;
                }
                break;
            }


            Console.Read();
        }

        static bool IsPrime(long value)
        {
            if (value == 2)
                return true;
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
