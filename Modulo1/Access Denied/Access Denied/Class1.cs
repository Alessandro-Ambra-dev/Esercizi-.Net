using System;

public class Animal
{
    internal string Name { get; set; }
    public string Description {internal set; get; }
    public int Age { get; set; }

    internal void Call()
    {
        Console.WriteLine($"{Name} come here!");
    }
    internal void Describe()
    { 
        Console.WriteLine($"{Name} is {Description}");


    }
}
