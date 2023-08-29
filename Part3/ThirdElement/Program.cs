using System;
using System.Collections.Generic;

namespace ThirdElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "") break;
                else names.Add(name);
            }

            Console.WriteLine(names[2]);

            // System.Console.WriteLine();
            // names.ForEach(name => Console.WriteLine(name + " "));
        }



    }
}
