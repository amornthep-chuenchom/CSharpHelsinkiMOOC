using System;

namespace DivisibleByThree
{
    class Program
    {
        static void Main(string[] args)
        {
            DivisibleByThreeInRange(2, 10);
        }

        public static void DivisibleByThreeInRange(int beginning, int ending)
        {
            for (int i = beginning; i <= ending; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
