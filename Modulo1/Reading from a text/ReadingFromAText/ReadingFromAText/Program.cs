Console.WriteLine("Please put here some greetings:");


string response =  Console.ReadLine();

var path = "./output.txt";

var path2 = "./output.ppt";

File.WriteAllText(path2, response);




File.AppendAllLines(path, new[]{ response });
File.AppendAllLines(path2, new[]{ response });


var text = File.ReadAllText(path);
var text2 = File.ReadAllText(path2);

Console.WriteLine(text);
Console.WriteLine(text2);