using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string verse = "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man";

        Reference reference = new Reference("Moses", 1, 39);
        //Console.Write(reference.GetDisplayText());
        Scripture scripture = new Scripture(reference, verse);
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Press Enter to Continue or quit to exit.");
        string answer = Console.ReadLine();
        if (answer == "quit")
        {
            System.Environment.Exit(0); //terminates program (built in method)
        }
        else
        {
            scripture.HideRandomWords();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}