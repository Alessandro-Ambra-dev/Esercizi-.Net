// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write some text:");

var Words = new List<string>();

for (int i = 0; i < 10; i++)
{
    var item = Console.ReadLine();
    Words.Add(item);
}

Console.WriteLine("The list of words is: ");
foreach (var word in Words)
{
    Console.WriteLine(word);
}

Console.WriteLine("The reversed list of words is: ");

for (int i =(Words.Count -1); i>=0; i-- )
{
    var item= Words[i];
   Console.WriteLine(item);
}








