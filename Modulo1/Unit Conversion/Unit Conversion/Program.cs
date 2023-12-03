Console.WriteLine("Please insert a degree in Celsius");

string input = Console.ReadLine();

double celsius = int.Parse(input);

Console.WriteLine("Converting in Fahrenhite...");

double far = (celsius * 1.8d) + 32;

Console.WriteLine(far);