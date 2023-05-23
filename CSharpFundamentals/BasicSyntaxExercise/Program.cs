// Problem 11: *Orders
Console.Clear();

int n = int.Parse(Console.ReadLine());
decimal sum = 0.0m;
decimal[] sumsPC = new decimal[n];

for (int i = 0; i < n; i++)
{
    decimal pPC = decimal.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int cCount = int.Parse(Console.ReadLine());

    sum += pPC * days * cCount;
    sumsPC[i] = pPC * days * cCount;
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine("The price for the coffee is: ${0:0.00}", sumsPC[i]);
}

Console.Write("Total: ${0:0.00}", sum);