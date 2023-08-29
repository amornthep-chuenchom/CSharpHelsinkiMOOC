using System;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new [] {5, 1, 3, 4, 2};

            Console.WriteLine(SumOfNumbersInArray(array));
        }

        static int SumOfNumbersInArray(int[] array)
        {
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }

            return sum;
        }
    }
}
