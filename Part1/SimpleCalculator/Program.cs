using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give the first second: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNum + " + " + secondNum + " = " + (firstNum + secondNum));
            Console.WriteLine(firstNum + " - " + secondNum + " = " + (firstNum - secondNum));
            Console.WriteLine(firstNum + " * " + secondNum + " = " + (firstNum * secondNum));
            Console.WriteLine(firstNum + " / " + secondNum + " = " + ((float)firstNum / secondNum));
        }
    }
}
