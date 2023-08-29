using System;

namespace PersonalDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            double average;
            string longestName = "";


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "") break;

                string[] person = input.Split(',');
                string personName = person[0];
                int personBirthYear = Convert.ToInt32(person[1]);
                sum += personBirthYear;
                count++;


                if (personName.Length > longestName.Length) longestName = personName;
            }

            average = (double)sum / count;
            Console.WriteLine("Longest name: " + longestName);
            Console.WriteLine("Average of the birth years: " + average);
        }
    }
}
