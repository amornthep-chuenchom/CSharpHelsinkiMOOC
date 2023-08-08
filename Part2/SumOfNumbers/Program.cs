int sum = 0;

while (true)
{
    Console.Write("Give a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0) break;

    sum += number;
}

Console.WriteLine($"Sum of the numbers: {sum}");