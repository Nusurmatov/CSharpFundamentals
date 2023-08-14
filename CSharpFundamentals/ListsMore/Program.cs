// Problem 5 - Drum Set:
var savings = Convert.ToSingle(Console.ReadLine());
var initialQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
var command = Console.ReadLine();

var result = new List<int>(initialQuality);
while (command != "Hit it again, Gabsy!")
{
    int hitPower = Convert.ToInt32(command);
    for (int i = 0; i < result.Count; i++)
    {
        result[i] -= hitPower;
        if (result[i] <= 0)
        {
            if (savings >= initialQuality[i] * 3f)
            {
                result[i] = initialQuality[i];
                savings -= initialQuality[i] * 3f;
            }
        }
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(' ', result.Where(n => n > 0)));
Console.Write($"Gabsy has {savings:f2}lv.");
