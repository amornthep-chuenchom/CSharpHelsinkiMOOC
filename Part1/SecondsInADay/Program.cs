using System;

namespace SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many days would you like to convert to seconds?: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int daysToSeconds = days * 24 * 60 * 60;
            Console.WriteLine(daysToSeconds);
        }
    }
}
