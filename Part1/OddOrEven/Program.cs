using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0) 
            {
                Console.Write("Number is even.");
            }
            else
            {
                Console.Write("Number is odd.");
            }
        }
    }
}
