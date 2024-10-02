using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's test the program...");

        // Calling the first Constructor "OneFraction"

        Fraction firstFraction = new Fraction();
        firstFraction.OneFraction(); // value 1/1

        //Calling second constructor "TwoFraction" and assigning the number 5 to the top (nominator)
        Fraction secondFraction = new Fraction();
        secondFraction.TwoFraction(5); // value of 5 for top variable = 5/1

        //Calling third constructor "ThreeFraction" and assigning the number 5 to the top (nominator)
        Fraction thirdFraction = new Fraction();
        thirdFraction.ThreeFraction(1, 2); //Assigning nominator and denominator = 1/2

        //Calling the Nominator and Denominator and setting a value in the GetFractionString method.

        Fraction newNominator = new Fraction();

        newNominator.GetFraction(3, 4); //Values: Nominator: 3  / Denominator: 4 = 3/4
    }
}