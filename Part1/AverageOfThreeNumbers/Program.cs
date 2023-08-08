using System;

namespace AverageOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give the third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            float average = (float)(firstNumber + secondNumber + thirdNumber) / 3;
            Console.WriteLine("The average is " + average);
        }
    }
}
