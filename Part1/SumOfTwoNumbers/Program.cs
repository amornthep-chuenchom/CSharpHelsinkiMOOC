using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sumOfTwoNumbers = firstNumber + secondNumber;
            System.Console.WriteLine("The sum of the numbers is " + sumOfTwoNumbers);
        }
    }
}
