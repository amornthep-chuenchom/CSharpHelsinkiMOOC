int count = 0;
int sum = 0;
double average;

while (true)
{
    Console.Write("Give a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0) break;

    count++;
    sum += number;
}

average = (double)sum / count;

Console.WriteLine($"Average of numbers: {average}");
