using System;

namespace Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Smallest(8, 7);
            System.Console.WriteLine("Smallest: " + answer);
        }

        static int Smallest(int number1, int number2) => number1 < number2 ? number1 : number2;
    }
}
