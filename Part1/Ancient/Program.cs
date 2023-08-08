using System;

namespace Ancient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 2015) System.Console.WriteLine("Ancient History!");
        }
    }
}
