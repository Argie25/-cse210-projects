using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcom to the program!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        static void Demo(string name,int number)
        {
            double square = Math.Pow(number, 2);
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        Demo(name, number);
    }
}