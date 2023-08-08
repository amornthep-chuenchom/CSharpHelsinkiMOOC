using System;

namespace Reprint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times? ");
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= numberOfTimes)
            {
                PrintText();
                i++;
            }
        }

        public static void PrintText()
        {
            Console.WriteLine("In a hole in the ground there lived a method");
        }
    }
}
