// Problem 7 - Water Overflow:

short n = Convert.ToInt16(Console.ReadLine());
short currentQuantity = 0;
for (short i = 0; i < n; i++)
{
    short liters = Convert.ToInt16(Console.ReadLine());
    if (liters > 255)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        currentQuantity += liters;
    }
}

Console.Write(currentQuantity);