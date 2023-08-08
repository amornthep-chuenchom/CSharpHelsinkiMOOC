Console.Write("Value of the gift? ");
int giftValue = Convert.ToInt32(Console.ReadLine());

double giftTax = 0;

int giftValueAtLowerLimit = 0;
int taxAtLowerLimit = 0;
int exceedingTaxRate = 0;

if (giftValue >= 5000 && giftValue < 25000)
{
    giftValueAtLowerLimit = 5000;
    taxAtLowerLimit = 100;
    exceedingTaxRate = 8;
}
else if (giftValue >= 25_000 && giftValue < 55_000)
{
    giftValueAtLowerLimit = 25_000;
    taxAtLowerLimit = 1700;
    exceedingTaxRate = 10;
}
else if (giftValue >= 55_000 && giftValue < 200_000)
{
    giftValueAtLowerLimit = 55_000;
    taxAtLowerLimit = 4700;
    exceedingTaxRate = 12;
}
else if (giftValue >= 200_000 && giftValue < 1_000_000)
{
    giftValueAtLowerLimit = 200_000;
    taxAtLowerLimit = 22_100;
    exceedingTaxRate = 15;
}
else if (giftValue >= 1_000_000)
{
    giftValueAtLowerLimit = 1_000_000;
    taxAtLowerLimit = 142_100;
    exceedingTaxRate = 17;
}

giftTax = (taxAtLowerLimit + (giftValue - giftValueAtLowerLimit) * ((double)exceedingTaxRate / 100));

if (giftTax == 0) 
    Console.WriteLine("No Tax!");
else if (giftTax > 0)
    Console.WriteLine($"Tax: {giftTax}");
else 
    Console.WriteLine("Error!");


    