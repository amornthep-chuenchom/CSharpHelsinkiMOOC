using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set & display array
            int[] array = new [] { 1, 3, 5, 7, 9 };
            PrintArray(array);
            System.Console.WriteLine();
            
            // Get indice to swap
            Console.WriteLine("Give two indices to swap: ");
            int firstIndex = Convert.ToInt32(Console.ReadLine());
            int secondIndex = Convert.ToInt32(Console.ReadLine());

            // Swap value in array
            int helper = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = helper;

            // Display array after swap
            System.Console.WriteLine();
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
