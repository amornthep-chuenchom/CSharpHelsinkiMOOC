using System;

namespace MessageThreeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a message: ");
            string message = Console.ReadLine();
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
        }
    }
}
