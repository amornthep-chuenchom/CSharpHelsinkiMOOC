using System;
using System.Collections.Generic;

namespace SecondPlusThird
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0) break;
                else numbers.Add(number);

            }

            Console.WriteLine(numbers[1] + numbers[2]);
        }
    }
}
