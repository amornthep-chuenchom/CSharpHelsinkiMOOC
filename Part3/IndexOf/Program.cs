using System;
using System.Collections.Generic;

namespace IndexOf
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
                8,
                11
            };

            // Implement Search index of number
            Console.Write("Search for? ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (searchNumber == list[i])
                    Console.WriteLine($"{searchNumber} is at index {i}");
            }
        }
    }
}
