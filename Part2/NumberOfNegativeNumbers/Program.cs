int count = 0;

while (true)
{
    Console.Write("Give a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0) break;
    else if (number < 0) count++;
}

Console.WriteLine($"Number of negative numbers: {count}");

