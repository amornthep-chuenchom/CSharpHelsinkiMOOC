while (true) 
{
    Console.Write("Give a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 0) Console.WriteLine("Unsuitable number");
    else if (number > 0) Console.WriteLine(Math.Pow(number, 2));
    else break;
}

