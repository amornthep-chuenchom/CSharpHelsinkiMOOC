using System;
using System.Collections.Generic;

namespace FirstAndLast
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

            Console.WriteLine(list[0]);
            Console.WriteLine(list[list.Count - 1]);
        }
    }
}
