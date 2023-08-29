using System;

namespace PrintThrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a word: ");
            string word = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
                Console.Write(word);
        }
    }
}
