using System;

namespace SpeedingTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed > 120) Console.WriteLine("Speeding ticket!");
        }
    }
}
