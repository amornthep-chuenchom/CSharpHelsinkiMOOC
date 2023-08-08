using System;

namespace Orwell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number == 1984) System.Console.WriteLine("Orwell");
        }
    }
}
