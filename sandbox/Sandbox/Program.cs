using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!!!");
        Console.WriteLine("This is how to print in C#");

        Console.Write("What is the color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"The color is {color}");
    }
}