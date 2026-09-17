// See https://aka.ms/new-console-template for more information
using fajlbeolvasas;
using System.Net.WebSockets;

Console.WriteLine("Hello, Freind!");
Console.WriteLine("----------------------");
Model model = new Model();
Console.WriteLine(model.list.Count());
Console.WriteLine("----------------------");

model.feledet2(2000).ForEach(x => Console.WriteLine(x));
Console.WriteLine("----------------------");

model.feledet3(500).ForEach(x => Console.WriteLine(x));
Console.WriteLine("----------------------");

model.feledet4(300000).ForEach(x => Console.WriteLine(x));
Console.WriteLine("----------------------");

Console.WriteLine(model.feledet5("Mercedes"));
Console.WriteLine("----------------------");

if (model.feledet6("Tesla"))
    {
        Console.WriteLine("true");
    }
else
    Console.WriteLine("false");
Console.WriteLine("----------------------");

if (model.feledet7(500))
{
    Console.WriteLine("true");
}
else
    Console.WriteLine("false");
Console.WriteLine("----------------------");
Console.WriteLine(model.feladat8());

