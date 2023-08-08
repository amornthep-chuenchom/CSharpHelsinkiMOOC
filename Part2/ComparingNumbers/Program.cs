Console.Write("Enter first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second) Console.WriteLine($"{first} is greater than {second}.");
else if (second > first) Console.WriteLine($"{first} is smaller than {second}.");
else Console.WriteLine($"{first} is equal to {second}");


