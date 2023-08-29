using System;

namespace AVClub
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

                foreach (string word in words)
                {
                    if (word.Contains("av"))
                        Console.WriteLine(word);
                }
            }
        }
    }
}
