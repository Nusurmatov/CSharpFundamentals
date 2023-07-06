// Problem 11 - Math Operations:
int a = Convert.ToInt32(Console.ReadLine());
var @operator = Console.ReadLine();
int b = Convert.ToInt32(Console.ReadLine());
double result = Calculate(a, @operator, b);
Console.Write(result);

double Calculate(int a, string? @operator, int b) => @operator switch
{
    "+" => a + b,
    "-" => a - b,
    "*" => a * b,
    _ => a / b
};
