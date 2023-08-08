using System;

namespace IntegerInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You gave the number " + number);
        }
    }
}
