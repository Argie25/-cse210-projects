using System;

class Program
{
    static void Main(string[] args)
    {
        var Fraction1 = new Fraction();
        Console.WriteLine(Fraction1.GetFunctionString());
        Console.WriteLine(Fraction1.GetDecimalValue());

        var Fraction2 = new Fraction(5);
        Console.WriteLine(Fraction2.GetFunctionString());
        Console.WriteLine(Fraction2.GetDecimalValue());
        
        var Fraction3 = new Fraction(3,4);
        Console.WriteLine(Fraction3.GetFunctionString());
        Console.WriteLine(Fraction3.GetDecimalValue());

    }
}