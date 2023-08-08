using System;

namespace AverageOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            float average = (float)(firstNum + secondNum) / 2;
            Console.WriteLine("The average is " + average);
        }
    }
}
