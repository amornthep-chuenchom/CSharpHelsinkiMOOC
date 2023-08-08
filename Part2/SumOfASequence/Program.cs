int sum = 0;

Console.Write("First number? ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Last number? ");
int lastNumber = Convert.ToInt32(Console.ReadLine());

for (int i = firstNumber; i <= lastNumber; i++)
{
    sum += i;
}

Console.WriteLine($"The sum is {sum}.");


