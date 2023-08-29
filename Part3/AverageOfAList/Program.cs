using System;
using System.Collections.Generic;

namespace AverageOfAList
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
            double average;
            
            list.ForEach(value => sum += value);
            
            average = (double)sum / list.Count;

            Console.WriteLine("Average: " + average);
        }
    }
}
