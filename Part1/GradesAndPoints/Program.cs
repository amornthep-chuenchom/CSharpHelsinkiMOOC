Console.Write("Give points [0-100]: ");
int points = Convert.ToInt32(Console.ReadLine());

if (points <  0) System.Console.WriteLine("impossible!");
else if (points >= 0 && points <= 49) System.Console.WriteLine("failed");
else if (points >= 50 && points <= 59) System.Console.WriteLine("1");
else if (points >= 60 && points <= 69) System.Console.WriteLine("2");
else if (points >= 70 && points <= 79) System.Console.WriteLine("3");
else if (points >= 80 && points <= 89) System.Console.WriteLine("4");
else if (points >= 90 && points <= 100) System.Console.WriteLine("5");
else if (points > 100) System.Console.WriteLine("incredible!");


