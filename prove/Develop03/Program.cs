using System;
using System.Formats.Asn1;
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

        //initialize string answer
        string answer;

        do
        {
            Console.WriteLine("Press Enter to Continue or type quit to exit.");
            answer = Console.ReadLine();
            if (answer == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.WriteLine(scripture.GetDisplayText());
        } while (!scripture.IsCompletelyHidden()); //while the scripture is not ! completely hidden- keep running the code.

    }
}