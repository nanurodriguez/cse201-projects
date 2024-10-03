using System;
using System.Diagnostics;
using System.Reflection;


public class Fraction
{
    private int _topNumerator;
    private int _bottomDenominator;

    //Constructor 
    public Fraction()
    {
        _topNumerator = 1;
        _bottomDenominator = 1;
    }

    //Constructor 
    public Fraction(int five)
    {
        _topNumerator = five;
        _bottomDenominator = 1;

    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumerator = topNumber;
        _bottomDenominator = bottomNumber;
    }

    //Adding a method that will retrieve the form of the actual Fraction for every Constructor and setter we have mentioned above

    public string GetFractionString()
    {
        string fraction = $"{_topNumerator} / {_bottomDenominator}";
        return fraction;

    }

    public double GetDecimalValue()
    {

        return (double)_topNumerator / (double)_bottomDenominator;

    }


}
