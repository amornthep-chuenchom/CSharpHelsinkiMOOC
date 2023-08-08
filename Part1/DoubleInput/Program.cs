using System;

namespace DoubleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("You gave the number " + number);
        }
    }
}
