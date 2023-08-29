using System;

namespace LineByLine
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
                    Console.WriteLine(word);
                }
            }
        }
    }
}
