using System;

class Program
{
    static void Main(string[] args)
    {
        // Practice input and output
        Console.Write("What is your first name: ");
        string f_name = Console.ReadLine();
        Console.Write("What is your las name: ");
        string l_name = Console.ReadLine();
        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}.");
    }
}