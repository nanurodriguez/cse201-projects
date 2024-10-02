using System;
using System.Diagnostics;
using System.Reflection;


public class Fraction
{
    private int topNumerator;
    private int bottomDenominator;

    //Constructor OneFraction
    public void OneFraction()
    {
        topNumerator = 1;
        bottomDenominator = 1;
        //Console.WriteLine($"{topNumerator} / {bottomDenominator}");
        //Display: Console.WriteLine("Fraction: " + firstFraction.Fraction() );

    }

    //Constructor TwoFraction
    public void TwoFraction(int top)
    {
        topNumerator = top;
        bottomDenominator = 1;
        //Console.WriteLine($"{topNumerator} / {bottomDenominator}");

    }


    // Getter for the Nominator or topNumerator
    public int GetNominator()
    {
        return topNumerator;
    }
    // Getter for the Denominator or bottomDenominator

    public int GetDenominator()
    {
        return bottomDenominator;
    }

    //Setter for the GetFraction
    public void GetFraction(int topNumber, int bottomNumber)
    {
        topNumerator = topNumber;
        bottomDenominator = bottomNumber;
        //Console.WriteLine($"{topNumber} / {bottomNumber}");
    }

    //Adding a method that will retrieve the form of the actual Fraction for every Constructor and setter we have mentioned above

    public void GetFractionString(int top, int bottom)
    {
        topNumerator = top;
        bottomDenominator = bottom;
        Console.WriteLine($"{top} / {bottom}");

    }

    public void GetDecimalValue(int top, int bottom)
    {
        topNumerator = top;
        bottomDenominator = bottom;

        decimal divide = top / bottom;

        while (divide != 0)
        {
            Console.WriteLine(divide);

        }


    }


}
