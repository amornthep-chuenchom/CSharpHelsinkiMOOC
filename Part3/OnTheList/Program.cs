using System;
using System.Collections.Generic;

namespace OnTheList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Tom",
                "Emma",
                "Alex",
                "Mary"
            };

            // Implement

            Console.Write("Search for? ");
            string search = Console.ReadLine();
            bool isFound = false;

            list.ForEach(value => 
            {
                if (value == search) isFound = true;
            });

            if (isFound) Console.WriteLine($"{search} was found!");
            else Console.WriteLine($"{search} was not found!");
        }
    }
}
