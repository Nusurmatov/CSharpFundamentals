// Problem 11 - Snowballs:

using System.Numerics;

int n = Convert.ToInt32(Console.ReadLine());
var snowballs = new List<SnowBall>();

for (int i = 0; i < n; i++)
{
    int snowballSnow = Convert.ToInt32(Console.ReadLine());
    int snowballTime = Convert.ToInt32(Console.ReadLine());
    int snowballQuality = Convert.ToInt32(Console.ReadLine());
    BigInteger snowballValue = Pow(snowballSnow / snowballTime, snowballQuality);
    var snowball = new SnowBall(snowballSnow, snowballTime, snowballQuality, snowballValue); 

    snowballs.Add(snowball);
}
var maxSnowBall = snowballs.MaxBy(s => s.snowballValue);
Console.WriteLine($"{maxSnowBall.snowballSnow} : {maxSnowBall.snowballTime} = {maxSnowBall.snowballValue} ({maxSnowBall.snowballQuality})");

BigInteger Pow(int n, int power)
{
    BigInteger result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= n;
    }

    return result;
}

record SnowBall(int snowballSnow, int snowballTime, int snowballQuality, BigInteger snowballValue);