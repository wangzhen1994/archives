﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //The sum of the squares of the first ten natural numbers is,

            //12 + 22 + ... + 102 = 385
            //The square of the sum of the first ten natural numbers is,

            //(1 + 2 + ... + 10)2 = 552 = 3025
            //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

            //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            int num = 100;

            int sum = 0;

            int sum1 = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += i;
                sum1 += i * i;
            }

            Console.WriteLine(sum*sum-sum1);
            Console.Read();
        }
    }
}
