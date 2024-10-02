public class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor
    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denamenator)
    {
        _top = numerator;
        _bottom = denamenator;
    }
    // Function
    public string GetFunctionString()
    {
        string text = ($"{_top}/{_bottom}");
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}