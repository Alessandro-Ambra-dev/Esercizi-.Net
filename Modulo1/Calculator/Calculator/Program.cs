// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter the first number..");

string textA = Console.ReadLine();

int numberA = int.Parse(textA);

Console.WriteLine("Choose the operator");

string op=Console.ReadLine();

if (op.Length != 1)
{
    Console.WriteLine("Invalid input, try again later.");
    Environment.Exit(1);
    return;
}

Console.WriteLine("Please enter the second number..");

string textB = Console.ReadLine();  

int numberB = int.Parse(textB);

int result;




char operatorChar = op.First();

switch(operatorChar)
{
    case '+':
        result = numberA + numberB;
        break;
    case '-':
        result = numberA - numberB;
        break;
    case '*':
        result = numberA * numberB;
        break;
    case '/':
        result = numberA / numberB;
        break;
    default:
        Console.WriteLine($"Invalid operator: {operatorChar}, try again later");
        Environment.Exit(1);
        return;
}

Console.Write($"{numberA} {op} {numberB} = ");
Console.WriteLine(result);