using System;
using SimpleStack;

var stack = new MySimpleStack();
string? answer = null;
string commands = @"Commands:
    top - view the top value of the stack\n
    pop - pop off the top value of the stack\n
    type an integer to push it to the stack!
    exit to quit
";

while (answer != "exit")
{
    Console.WriteLine(commands);
    answer = Console.ReadLine();
    Console.WriteLine();
    bool push = int.TryParse(answer, out int result);
    if (push)
    {
        stack.Push(int.Parse(answer));
        Console.WriteLine($"{answer} pushed onto stack.\n");
    }
    else
    {
        switch (answer)
        {
            case "top":
                if (stack.Count > 0)
                    Console.WriteLine($"Top value is: {stack.Top}\n");
                else
                    Console.WriteLine("Stack is empty!\n");
                break;
            case "pop":
                if (stack.Count > 0)
                {
                    Console.WriteLine($"{stack.Top} popped off the stack.\n");
                    stack.Pop();
                }
                else
                    Console.WriteLine("Stack is empty!\n");
                break;
            default:
                Console.WriteLine("Unrecognised input!\n");
                break;
        }
    }
}








