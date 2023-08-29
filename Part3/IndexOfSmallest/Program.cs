using System;
using System.Collections.Generic;

namespace IndexOfSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                72,
                44,
                8,
                8,
                11
            };

            // implement

            // for (int i = 0; i < list.Count; i++)
            // {
            //     if (list[i] < smallestNumber)
            //     {
            //         smallestNumber = list[i];
            //     }
            // }

            int smallestNumber = Int32.MaxValue;

            list.ForEach(value => 
            {
                if (value < smallestNumber) smallestNumber = value;
            });

            Console.WriteLine("Smallest number: " + smallestNumber);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == smallestNumber)
                    Console.WriteLine("Found at index: " + i);
            }

        }
    }
}
