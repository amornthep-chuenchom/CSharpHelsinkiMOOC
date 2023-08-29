using System;
using System.Collections.Generic;

namespace OnlyTheseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == -1) break;
                else list.Add(number);
            }

            // Implement
            Console.WriteLine();

            Console.Write("From Where? ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("To Where? ");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= end; i++)
                Console.WriteLine(list[i]);
        }
    }
}
