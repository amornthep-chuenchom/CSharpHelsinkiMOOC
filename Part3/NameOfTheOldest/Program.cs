using System;

namespace NameOfTheOldest
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldestName= "";
            int oldestAge = Int32.MinValue;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "") break;

                string[] person = input.Split(',');
                
                string personName = person[0];
                int personAge = Convert.ToInt32(person[1]);

                if (personAge > oldestAge)
                {
                    oldestAge = personAge;
                    oldestName = personName;
                }
            }

            Console.WriteLine("Name of the oldest: " + oldestName);
        }
    }
}
