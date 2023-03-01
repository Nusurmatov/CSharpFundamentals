// Problem 6: Strong Number
Console.Clear();

int Factorial(int n)
{
    int f = 1;

    for (int i = 1; i <= n; i++)
    {
        f *= i;   
    }

    return f;
}

string num = Console.ReadLine();
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    sum += Factorial(num[i] - 48);
}

Console.Write(int.Parse(num) != sum ? "no" : "yes");