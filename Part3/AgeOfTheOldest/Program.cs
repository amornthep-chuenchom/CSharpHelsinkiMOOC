using System;

namespace AgeOfTheOldest
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldestAge = Int32.MinValue;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "") break;

                string[] person = input.Split(',');
                int age = Convert.ToInt32(person[1]);

                if (age > oldestAge) oldestAge = age;

            }

            Console.WriteLine("Age of the oldest: " + oldestAge);
        }
    }
}
