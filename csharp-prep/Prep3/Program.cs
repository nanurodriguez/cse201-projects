using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        string userInputmagic = Console.ReadLine();
        float magicNumber = float.Parse(userInputmagic);

        Console.Write("What is your guess?");
        string userInput = Console.ReadLine();
        float guessNumber = float.Parse(userInput);


    }
}