using System;
using System.Collections.Generic;

namespace SumOfAList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                72,
                2,
                8,
                11
            };

            // implement

            int sum = 0;

            list.ForEach(value => sum += value);

            Console.WriteLine("Sum: " + sum);
        }
    }
}
