int firstNum;
int secondNum;
int sum = 0;
double square;

do
{
    Console.WriteLine("Please enter positive or zero...");
    Console.Write("Enter the first number: ");
    firstNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the second number: ");
    secondNum = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
} while (firstNum < 0 || secondNum < 0);

sum = firstNum + secondNum;

square = Math.Sqrt(sum);

Console.WriteLine($"Square root of {sum} is {square:F5}");
