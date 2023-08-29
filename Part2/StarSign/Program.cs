using System;

namespace StarSign
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            System.Console.WriteLine();
            PrintSquare(4);
            System.Console.WriteLine();
            PrintRectangle(17, 3);
            System.Console.WriteLine();
            PrintTriangle(4);
        }

        static void PrintStars(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();
        }

        static void PrintSquare(int size)
        {
            for (int i = 1; i <= size; i++)    
            {
                PrintStars(size);
            }
        }

        static void PrintRectangle(int width, int height)
        {
            for (int i = 1; i <= height; i++)
            {
                PrintStars(width);
            }
        }

        static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintStars(i);
            }
        }
    }
}
