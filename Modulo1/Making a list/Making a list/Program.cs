Console.WriteLine("Hello, write your first list");



string[] input = new string[10];

string[] revered = input;

for(int i = 0; i < input.Length; i++)
{
    input[i] = Console.ReadLine();
}

Console.WriteLine("The original Array is:");

foreach (var s in input)
{
    Console.WriteLine(s);
}



Array.Reverse(revered);

Console.WriteLine("The reversed Array is:");

foreach(var s in revered)
{
    Console.WriteLine(s);
}




