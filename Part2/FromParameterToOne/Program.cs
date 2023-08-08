using System;

namespace FromParameterToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFromNumberToOne(2);
        }

        public static void PrintFromNumberToOne(int number)
        {
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}
