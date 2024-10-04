using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();

        Console.WriteLine("Testing Scripture Memorizer: ");
        Console.WriteLine(scripture.GetDisplayText());

        //Calling the GetDisplayText to display first reference
        Reference reference = new Reference("Moses", 1, 39);
        Console.WriteLine(reference.GetDisplayText());

        //Calling the GetDisplayText2 to display second reference
        Reference reference2 = new Reference("2 Nephi", 2, 6, 9);
        Console.WriteLine(reference2.GetDisplayText2());

        //Calling the GetDisplayText to display third reference 
        Reference reference3 = new Reference("2 Nephi", 32, 8);
        Console.WriteLine(reference3.GetDisplayText());
    }
}