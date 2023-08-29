using System;

namespace FirstWords
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "") break;

                string[] words = input.Split(' ');
                Console.WriteLine(words[0]);
            }
        }
    }
}
