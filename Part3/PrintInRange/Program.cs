using System;
using System.Collections.Generic;

namespace PrintInRange
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
                -1,
                5,
                1
            };

            Console.WriteLine("The numbers in the range [0, 5]");
            PrintNumbersInRange(list, 0, 5);
            Console.WriteLine("The numbers in the range [3, 10]");
            PrintNumbersInRange(list, 3, 10);
        }

        static void PrintNumbersInRange(List<int> list, int lowerLimit, int upperLimit)
        {
            foreach (int item in list)
            {
                if (item >= lowerLimit && item <= upperLimit)
                    Console.WriteLine(item);
            }
        }
    }
}
