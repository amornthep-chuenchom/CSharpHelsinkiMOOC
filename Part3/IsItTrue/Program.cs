﻿using System;

namespace IsItTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string input = Console.ReadLine();

            if (input == "true") Console.WriteLine("You got it right!");
            else Console.WriteLine("Try again!");

        }
    }
}
