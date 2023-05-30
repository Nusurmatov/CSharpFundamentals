// Problem 8: Condense Array to Number:
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (numbers.Length == 1)
{
    Console.Write(numbers.First());    
}
else
{
    int[] condensed = new int[numbers.Length]; 

    for (int i = 0; i < numbers.Length - 2; i++)
    {
        for (int j = 0; j < numbers.Length - i - 1; j++)
        {
            condensed[j] = numbers[j] + numbers[j+1];
        }
        Array.Copy(condensed, numbers, condensed.Length);
    }

    Console.Write(numbers[0] + numbers[1]);
}