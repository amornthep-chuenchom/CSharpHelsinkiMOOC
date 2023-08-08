using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            Division(3,5);
        }

        public static void Division(int numerator, int denominator) => Console.WriteLine((float)numerator / denominator);
        
    }
}
