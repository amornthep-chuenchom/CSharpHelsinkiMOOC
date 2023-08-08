int count = 0;
int sum = 0;

while (true) 
{
    Console.Write("Give a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0) break;

    count++;
    sum += number;
}

Console.WriteLine($"Number of numbers: {count}");
Console.WriteLine($"Sum of the numbers: {sum}");


