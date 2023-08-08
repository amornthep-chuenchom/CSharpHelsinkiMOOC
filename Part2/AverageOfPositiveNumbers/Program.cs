int count = 0;
int sum = 0;

while (true)
{
    Console.Write("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0) break;
    else if (number > 0)
    {
        count++;
        sum += number;
    }

}

if (count == 0) Console.WriteLine("Cannot calculate the average.");
else if (count > 0)
{
    float average = (float)sum / count;
    Console.WriteLine($"Average of positive numbers is {average}.");
}


