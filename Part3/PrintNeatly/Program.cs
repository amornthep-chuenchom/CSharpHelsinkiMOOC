using System;

namespace PrintNeatly
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new [] {5, 1, 3, 4, 2};
            PrintNeatly(array);
        }

        static void PrintNeatly(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
        }
    }
}
