using System;

class Program
{
    static void Main(string[] args)
    {
        // Practice Conditional
        Console.Write("What is your grade: ");
        string grade = Console.ReadLine();

        int x = int.Parse(grade);
        string letter;

        if (x >= 90)
        {
            letter = "A";
        }

        else if (x >= 80)
        {
            letter = "B";
        }

        else if (x >= 70)
        {
            letter = "C";
        }

        else if (x >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is, {letter}");


        if (x >= 70)
        {
            Console.WriteLine("Congrats you passed");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}