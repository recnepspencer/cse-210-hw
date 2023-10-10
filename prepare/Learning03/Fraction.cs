using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Properties for Top and Bottom with getters and setters
    public int Top
    {
        get { return _top; }
        set { _top = value; }
    }

    public int Bottom
    {
        get { return _bottom; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _bottom = value;
        }
    }

    // Constructors
    public Fraction() : this(1, 1) { }

    public Fraction(int top) : this(top, 1) { }

    public Fraction(int top, int bottom)
    {
        Top = top;
        Bottom = bottom;
    }

    // Representation Methods
    public string GetFractionString()
    {
        return $"{Top}/{Bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)Top / Bottom;
    }
}
