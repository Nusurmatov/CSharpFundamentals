// Problem 5 - Special Numbers. A number is special when its sum of digits is 5, 7 or 11.
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} -> {isSpecial(i)}");
}

bool isSpecial(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum == 5 || sum == 7 || sum == 11;
}