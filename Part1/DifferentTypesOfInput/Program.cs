using System;

namespace DifferentTypesOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string text = Console.ReadLine();
            Console.Write("Give an integer: ");
            int integer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give a double: ");
            double floatingPoint = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Give a boolean: ");
            bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());

            System.Console.WriteLine("You gave the string " + text);
            System.Console.WriteLine("You gave the integer " + integer);
            System.Console.WriteLine("You gave the double " + floatingPoint);
            System.Console.WriteLine("You gave the boolean " + trueOrFalse);
        }
    }
}
