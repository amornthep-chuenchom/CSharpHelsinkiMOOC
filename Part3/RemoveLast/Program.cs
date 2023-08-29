using System;
using System.Collections.Generic;

namespace RemoveLast
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("First");
            strings.Add("Second");
            strings.Add("Third");
            
            strings.ForEach(value => Console.Write(value + " "));
            Console.WriteLine();

            RemoveLast(strings);
            RemoveLast(strings);

            strings.ForEach(value => Console.Write(value + " "));
            Console.WriteLine();


        }

        static void RemoveLast(List<string> strings)
        {
            strings.RemoveAt(strings.Count - 1);
        }
    }
}
