using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("start");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }

        System.Console.WriteLine("end");


    }

}