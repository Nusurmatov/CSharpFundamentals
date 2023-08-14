// Problem 5: Messages
Console.Clear();

int count = int.Parse(Console.ReadLine());
var stBuilder = new System.Text.StringBuilder();

while (count > 0)
{
    var input = Console.ReadLine();

    int length = input.Length;
    int mainDigit = input[0] - 48;
    int offset =(mainDigit - 2) * 3;
    offset += mainDigit < 8 ? 0: 1;
    int letterIndex = offset + length - 1;

    stBuilder.Append(mainDigit != 0 ? (char)(letterIndex + 97) : ' ');

    count--;
}

Console.Write(stBuilder);