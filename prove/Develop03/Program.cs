using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();

        Console.WriteLine("Testing Scripture Memorizer: ");
        Console.WriteLine(scripture.GetDisplayText());

        Reference reference = new Reference("Moses", 1, 39);
        Console.WriteLine("Testing Reference...");
        Console.WriteLine(reference.GetDisplayText());

        Reference reference2 = new Reference("Moses", 1, 39, 40);
        Console.WriteLine("Testing Reference 2...");
        Console.WriteLine(reference2.GetDisplayText2());
    }
}