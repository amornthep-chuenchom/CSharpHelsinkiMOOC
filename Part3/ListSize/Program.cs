using System;
using System.Collections.Generic;

namespace ListSize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "") break;
                else list.Add(name);
            }

            Console.WriteLine($"In total: {list.Count}");
        }
    }
}
