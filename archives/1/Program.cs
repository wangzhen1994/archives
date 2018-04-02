using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://projecteuler.net/problem=1

            //如果我们列出所有低于10的自然数是3或5的倍数，我们得到3,5,6和9，这些倍数的总和为23。

            //找到1000以下所有3或5的倍数之和。

            int a = 3;
            int b = 5;

            List<int> list = new List<int>();

            for (int i = 3; i < 1000; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    list.Add(i);
                }
            }

            Console.WriteLine("1000以内3和5的倍数的数共有{0}个，总和为{1}。", list.Count, list.Sum());

            Console.ReadKey();
        }

    }
}
