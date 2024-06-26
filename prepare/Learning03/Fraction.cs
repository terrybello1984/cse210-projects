// Fraction.cs
public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructor without parameters
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter for the numerator
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with two parameters
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Properties to get and set the numerator and denominator
    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set { _denominator = value; }
    }

    // Method to get the fraction in string format
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
