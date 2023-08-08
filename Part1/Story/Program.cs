using System;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will tell you a story, but I need some information first.");
            Console.WriteLine("What is the main character called?");
            string name = Console.ReadLine();
            Console.WriteLine("What is their job?");
            string job = Console.ReadLine();

            Console.WriteLine("Here is the story: ");
            Console.WriteLine("Once upon a time there was " + name + ", who was a " + job + ".");
            Console.WriteLine("On the way to work, " + name + " reflected on life.");
            Console.WriteLine("Perhaps " + name + " will not be a " + job + " forever.");
        }
    }
}
