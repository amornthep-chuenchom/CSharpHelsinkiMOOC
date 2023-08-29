using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool firstAccount = userName == "alex" && password == "sunshine";
            bool secondAccount = userName == "emma" && password == "haskell";

            if (firstAccount || secondAccount) Console.WriteLine("You have successfully logged in!");
            else Console.WriteLine("Incorrect username or password!");
        }
    }
}
