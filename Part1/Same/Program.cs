using System;

namespace Same
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first string: ");
            string first = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string second = Console.ReadLine();

            if (first == second) Console.WriteLine("Same");
            else Console.WriteLine("Different");
        }
    }
}
