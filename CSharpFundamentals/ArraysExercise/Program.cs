// Problem 10 - Ladybugs
int fieldSize = Convert.ToInt32(Console.ReadLine());
int[] field = new int[fieldSize]; 
int[] ladyBugsPosition = Console.ReadLine().Split().Select(int.Parse).ToArray();
var input = Console.ReadLine();

// add ladybugs to fields
for (int i = 0; i < ladyBugsPosition.Length; i++)
{
    if (ladyBugsPosition[i] >= 0 && ladyBugsPosition[i] < fieldSize)
    {
        field[ladyBugsPosition[i]] = 1;
    }
}

// receive commands
while (input.Trim() != "end")
{
    var separatedCommand = input.Split();
    var command = new Command(
        position: int.Parse(separatedCommand[0]),
        direction: separatedCommand[1][0],
        length: int.Parse(separatedCommand[2])
    );

    MoveLadbug(command);
    input = Console.ReadLine(); 
}
Console.Write(string.Join(' ', field));

void MoveLadbug(Command command)
{
    if (command.position >= 0 && command.position < fieldSize && field[command.position] == 1)
    {
        field[command.position] = 0;
        int newPosition = 0; newPosition += command.direction == 'r' ? command.position + command.length : command.position -command.length;
        while (newPosition < fieldSize && newPosition >= 0)
        {
            if (field[newPosition] == 0)
            {
                field[newPosition] = 1;
                break;
            }
            else
            {
                newPosition += command.direction == 'r' ? command.length : -command.length;
            }
        }
    }
}

record Command(int position, char direction, int length); 