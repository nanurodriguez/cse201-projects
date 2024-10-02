using System;
using System.Reflection;


public class Fraction
{
    private int topNumerator;
    private int bottomDenominator;

    public void OneFraction()
    {
        topNumerator = 1;
        bottomDenominator = 1;
        Console.WriteLine($"{topNumerator} / {bottomDenominator}");
        //Display: Console.WriteLine("Fraction: " + firstFraction.Fraction() );

    }

    public void TwoFraction(int top)
    {
        topNumerator = top;
        bottomDenominator = 1;
        Console.WriteLine($"{topNumerator} / {bottomDenominator}");

    }

    public void ThreeFraction(int top, int bottom)
    {
        topNumerator = top;
        bottomDenominator = bottom;
        Console.WriteLine($"{topNumerator} / {bottomDenominator}");

    }

}
