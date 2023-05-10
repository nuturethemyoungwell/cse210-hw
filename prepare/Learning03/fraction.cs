using System;

public class Fraction
{
    private int _top;
    private int _bottom;
    //set constructor 
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //get fraction string 
    public string GetFractionString()
    {
        //name this variable as fractionText and return it.
        string fractionText = ($"{_top}/{_bottom}");
        return fractionText;
    }

    //get decimal value of the fraction statement
    public double GetDecimalValue()
    {
        return (double)_top /(double)_bottom;
    }
}
