using System;

namespace MultiplicationFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give the second number: ");
            int secondNum = Int32.Parse(Console.ReadLine());

            int sum = firstNum * secondNum;
            Console.WriteLine(firstNum + " * " + secondNum + " = " + sum);
        }
    }
}
