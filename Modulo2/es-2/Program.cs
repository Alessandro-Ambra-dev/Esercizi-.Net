// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

Console.WriteLine("This is an ArrayList");


ArrayList MyList = new ArrayList();

MyList.Add("hello");
MyList.Add(123);
MyList.Add(true);
MyList.Add(3.5);

foreach (var item in MyList)
{
    Console.WriteLine(item);
}