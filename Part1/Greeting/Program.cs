using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
        }
    }
}
