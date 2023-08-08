Console.Write("Give a year: ");
int years = Convert.ToInt32(Console.ReadLine());

bool divisibleBy4 = years % 4 == 0;
bool divisibleBy100 = years % 100 == 0;
bool divisibleBy400 = years % 400 == 0;

bool isLeapYear = (divisibleBy4 && !divisibleBy100) || (divisibleBy4 && divisibleBy100 && divisibleBy400);

if (isLeapYear)
    Console.WriteLine("The year is a leap year.");
else
    Console.WriteLine("The year is not a leap year.");


