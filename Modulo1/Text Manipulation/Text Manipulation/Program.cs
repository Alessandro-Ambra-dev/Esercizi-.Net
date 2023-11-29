
Console.WriteLine("Please enter some text");

string input = Console.ReadLine();

string reversed = string.Empty;


for (int i = input.Length - 1; i >= 0; i--)
{
    reversed += input[i];
}
Console.Write($"Reverse String is : {reversed} ");
