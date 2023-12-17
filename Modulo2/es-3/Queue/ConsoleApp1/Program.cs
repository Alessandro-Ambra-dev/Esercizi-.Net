// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose one of these options:");
Console.WriteLine("[1]-Queue");
Console.WriteLine("[2]-Deqeue");
Console.WriteLine("[3]-Peek");

char selection = Console.ReadKey().KeyChar;

Queue<string> strings = new Queue<string>();

strings.Enqueue("hello!");

if (selection == '1')
{
    Console.WriteLine("Put a string to Enqueue");
    string? input = Console.ReadLine();
    strings.Enqueue(input);
}
else if (selection == '2')
{
    Console.WriteLine("You are now Dequeuing an item");
    strings.Dequeue();
}
else if (selection =='3')
{
    Console.WriteLine($"Peeking the item to be dequeued: {strings.Peek()}");
}
else
{
    Console.WriteLine("not implemented yet");
}


