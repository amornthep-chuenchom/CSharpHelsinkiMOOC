using System;

namespace Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Greatest(7, 7, 3);
            System.Console.WriteLine("Greatest: " + answer  );
        }

        static int Greatest(int number1, int number2, int number3)
        {
            if (number1 >= number2 && number1 >= number3) return number1;
            else if (number2 >= number1 && number2 >= number3) return number2;
            else return number3;
        }
    }
}
