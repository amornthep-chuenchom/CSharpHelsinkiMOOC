using System;

namespace IndexWasNotFound
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 2, 8, 1, 3, 0, 9, 7, 8 };
            
            int searchNumber = AskNumber("Search for?");
            // int index = -999;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)     
            {
                if (searchNumber == array[i])
                {
                    isFound = true;
                    Console.WriteLine($"{searchNumber} is at index {i}.");
                }
            }

            if (!isFound) 
                Console.WriteLine($"{searchNumber} was not found.");
        }

        static int AskNumber(string text)
        {
            Console.Write(text + " ");
            int number = Convert.ToInt32(Console.ReadLine());

            return number;
        }
    }
}
