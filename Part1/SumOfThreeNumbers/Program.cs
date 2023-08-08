using System;

namespace SumOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give the third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            int sumOfThreeNumbers = first + second + third;
            Console.WriteLine("The sum of the numbers is " + sumOfThreeNumbers);
        }
    }
}
