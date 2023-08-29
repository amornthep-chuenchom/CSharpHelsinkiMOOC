using System;

namespace Summation
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = sum(4, 3, 6, 1);
            System.Console.WriteLine("Sum: " + answer);
        }

        static int sum(int number1, int number2, int number3, int number4) => number1 + number2 + number3 + number4;
        
    }
}
