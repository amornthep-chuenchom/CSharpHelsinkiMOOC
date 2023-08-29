using System;

namespace AdvancedAstrology
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintSpaces(2);
            // PrintStars(5);
            // PrintTriangle(4);

            ChristmasTree(4);
            System.Console.WriteLine("------------------------------------------------------------");
            ChristmasTree(10);
        }

        public static void PrintStars(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        public static void PrintSpaces(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(" ");
            }
        }

        public static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
            }
        }

        public static void ChristmasTree(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                PrintSpaces(height - i);

                // PrintStars(((height * 2) - 1) - ((height - i) * 2)); => 2height - 1 - (2height - 2i) => 2i - 1
                PrintStars(2 * i - 1);
            }
            PrintBase(height, 2);
        }

        public static void PrintBase(int treeHeight, int baseHeight)
        {
            for (int i = 1; i <= baseHeight; i++)
            {
                PrintSpaces(treeHeight - 2);
                // PrintStars(((treeHeight * 2) - 1) - ((treeHeight - 2) * 2));
                PrintStars(3);
            }
        }
    }
}
