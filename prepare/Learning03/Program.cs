using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's test the program...");

        // Calling the first Constructor "OneFraction"

        Fraction firstFraction = new Fraction();
        firstFraction.OneFraction();

        //Calling second constructor "TwoFraction" and assigning the number 5 to the top (nominator)
        // Fraction secondFraction = new Fraction();
        // secondFraction.TwoFraction(5);

        //Calling third constructor "ThreeFraction" and assigning the number 5 to the top (nominator)
        //Fraction thirdFraction = new Fraction();
        //thirdFraction.ThreeFraction(1, 2); //Assigning nominator and denominator

        //Calling the Nominator and Denominator and setting a value

        Fraction newNominator = new Fraction();

        newNominator.SetNominatorDenominator(2, 3); //Values: Nominator: 2/ Denominator: 3
    }
}