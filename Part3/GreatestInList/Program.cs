using System;
using System.Collections.Generic;

namespace GreatestInList
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

            // implement

            int greatestValue = Int32.MinValue;
            list.ForEach(value => 
            {
                if (value > greatestValue) greatestValue = value;
            });

            // foreach (int number in list)
            // {
            //     if (number > greatestValue) greatestValue = number;
            // }

            Console.WriteLine("The Greatest Number: " + greatestValue);
        }
    }
}
