int count = 0;

while (true)
{
    Console.Write("Give a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0) break;

    count++;
}

Console.WriteLine($"Number of numbers: {count}");
