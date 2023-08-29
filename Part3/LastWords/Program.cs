using System;

namespace LastWords
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
                Console.WriteLine(words[words.Length - 1]);
            }
        }
    }
}
