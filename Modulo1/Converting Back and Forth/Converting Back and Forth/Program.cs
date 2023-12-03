


Console.WriteLine("Choose between Celsius or Fahrenhite");
string cel = "Celsius";

string far = "Fahrenhite";

string input = Console.ReadLine();

if (input ==cel || input=="C")
{
    Console.WriteLine("Put the celsius temperature here");
    string temp = Console.ReadLine();
    double check = double.Parse(temp);
    Console.WriteLine($"The temperature in Far is {(check * 1.8) + 32} ");
}
else if (input==far|| input=="F")
{
    Console.WriteLine("Put the Far temperature here");
    string temp2 = Console.ReadLine();
    double check2 = double.Parse(temp2);
    Console.WriteLine($"The temperature in Celsius is {(check2 - 32) * 0.5556} ");
}



