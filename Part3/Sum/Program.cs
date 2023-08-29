using System;
using System.Collections.Generic;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                3,
                2,
                6,
                -1
            };
            Console.WriteLine(Sum(list));

            list.Add(5);
            list.Add(1);
            Console.WriteLine(Sum(list));
        }

        static int Sum(List<int> list)
        {
            int sum = 0;

            list.ForEach(value => sum += value);

            return sum;
        }
    }
}
