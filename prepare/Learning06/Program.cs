using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shape = new List<Shape>();


        var s1 = new Square("red", 10);
        shape.Add(s1);

        var s2 = new Rectangle("blue", 2,3);
        shape.Add(s2);

        var s3 = new Circle("green", 4);
        shape.Add(s3);

        foreach (Shape s in shape)
        {
            string color = s.GetColor();
 
            double area = s.GetArea();

            System.Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}