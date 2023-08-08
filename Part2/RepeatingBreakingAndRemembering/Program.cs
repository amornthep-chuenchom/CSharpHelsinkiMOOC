int sum = 0;
int count = 0;
int even = 0;
int odd = 0;
Console.WriteLine("Give a numbers: ");

while (true)
{
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == -1) break;

    sum += number;
    count++;

    if (number % 2 == 0) even++;
    else odd++;
}

float average = (float)sum / count;

Console.WriteLine("Thx! Bye!");
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Numbers: " + count);
Console.WriteLine("Average: " + average);
Console.WriteLine("Even: " + even);
Console.WriteLine("Odd: " + odd);