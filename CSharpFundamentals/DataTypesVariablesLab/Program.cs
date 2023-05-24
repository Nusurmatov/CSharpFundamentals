// Problem 12 - Refactor Special Numbers:
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    int tempNumber = i;
    int sumOfNumberDigits = 0;
    while (tempNumber > 0)
    {
        sumOfNumberDigits += tempNumber % 10;
        tempNumber = tempNumber / 10;
    }
    bool isSpecialNum = (sumOfNumberDigits == 5) || (sumOfNumberDigits == 7) || (sumOfNumberDigits == 11);
    Console.WriteLine("{0} -> {1}", i, isSpecialNum);
    sumOfNumberDigits = 0;
}