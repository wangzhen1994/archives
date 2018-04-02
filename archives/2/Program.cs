using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://projecteuler.net/problem=2
             * 
             * Fibonacci序列中的每个新项都是通过添加前两个项生成的。从1和2开始，前10项将是：

               1，2，3，5，8，13，21，34，55，89，...

               通过考虑斐波纳契数列中不超过四百万的条件，求出偶数项的和。
             */

            int sum = 0;
            int i = 1;
            while (true)
            {

                int value = Sum(i);
                Console.WriteLine("第{0}个数：{1}",i, value);
                i++;
                if (value <= 4000000)
                {
                    if (value % 2 == 0)
                    {
                        sum += value;
                    }
                    continue;
                }
                break;
            }

            Console.WriteLine("偶数项的和：{0}", sum);

            Console.ReadKey();
        }

        static int Sum(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            if (i == 2)
            {
                return 2;
            }
            return Sum(i - 2) + Sum(i - 1);
        }
    }
}
