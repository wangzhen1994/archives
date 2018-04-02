using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.*/
            List<int> list = new List<int>();

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    int value = i * j;
                    if (IsPalindromic(value))
                    {
                        list.Add(value);
                    }
                }
            }

            Console.WriteLine(list.Max());


            Console.ReadKey();
        }

        static bool IsPalindromic(int num)
        {
            var s = num.ToString();
            var ss = new string(s.Reverse().ToArray());
            return s == ss;
        }
    }
}
