// Problem 5: Messages
Console.Clear();

var input = Console.ReadLine();
var inputSpelled = input.ToCharArray();
Array.Reverse(inputSpelled);

Console.WriteLine(new string(inputSpelled));

// var games = new Dictionary<string, float>() {
//     { "OutFall 4", 39.99f },
//     { "CS: OG", 15.99f },
//     { "Zplinter Zell", 19.99f },
//     { "Honored 2", 59.99f },
//     { "RoverWatch", 29.99f },
//     { "RoverWatch Origins Edition", 39.99f },
// };

// var money = float.Parse(Console.ReadLine());
// float spent = 0.0f;
// var input = Console.ReadLine();

// while (input != "Game Time" && input != null)
// {
//     if (games.ContainsKey(input))
//     {
//         if (money >= games[input])
//         {
//             money -= games[input];
//             spent += games[input];
//             Console.WriteLine("Bought {0}", input);
//         }
//         else
//         {
//             Console.WriteLine("Too Expensive");
//         }    
//     }
//     else
//     {
//         Console.WriteLine("Not Found");
//     }

//     input = Console.ReadLine();
// }

// Console.WriteLine(money != 0.0f ? $"Total spent: {spent:c2}. Remaining: {money:c2}" : 
//                                    "Out of money!");