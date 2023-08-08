Console.Write("Give the first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Give the second number: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second)
{
    System.Console.WriteLine("Greater number is: " + first);
}
else if (second > first)
{
    System.Console.WriteLine("Greater number is: " + second);
}
else
{
    System.Console.WriteLine("The number are equal!");
}
