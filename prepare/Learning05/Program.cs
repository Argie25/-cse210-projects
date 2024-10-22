using System;

class Program
{
    static void Main(string[] args)
    {
        var math = new MathAssignment("Argie", "Fraction", "7.9", "8-19");

        System.Console.WriteLine(math.GetSummary());
        System.Console.WriteLine(math.GetHomeworkList());

        var english = new WritingAssignment("Genesis", "Greek History", "A Greaat Book");
        System.Console.WriteLine(english.GetWritingInfo());
    }
}