using System;

namespace PrintInStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new [] {5, 1, 3, 4, 2};

            PrintArrayInStars(array);
        }

        static void PrintArrayInStars(int[] array)
        {
            foreach (int value in array)
            {
                PrintStars(value);
            }
        }

        static void PrintStars(int numberOfStars)
        {
            for (int i = 1; i <= numberOfStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
