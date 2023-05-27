// Problem 6 - Balanced Brackets:
int n = int.Parse(Console.ReadLine());
bool isBalanced = true;
Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if (input == "(")
    {
        stack.Push(i);
    }
    else if(input == ")")
    {
        if (stack.Count == 0)
        {
            isBalanced = false;
        } 
        else
        {
            stack.Pop();
        }      
    }
}

if (stack.Count != 0)
{
    isBalanced = false;
}

Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");