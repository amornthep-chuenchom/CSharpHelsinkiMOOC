int factorial = 1;

Console.Write("Give a number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0) Console.WriteLine("Please provide a positive integer.");
else
{
    for (int i = 2; i <= n; i++)
        factorial *= i;

    Console.WriteLine($"Factorial: {factorial}");
}
