using System;

namespace Averaging
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = Average(4, 3, 6, 1);
            System.Console.WriteLine("Average: " + answer);
        }

        static int Sum(int number1, int number2, int number3, int number4) => number1 + number2 + number3 + number4;

        static double Average(int number1, int number2, int number3, int number4) => (double)Sum(number1, number2, number3, number4) / 4;
        
    }
}
