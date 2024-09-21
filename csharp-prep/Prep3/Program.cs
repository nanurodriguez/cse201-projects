using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        string userInputmagic = Console.ReadLine();
        float magicNumber = float.Parse(userInputmagic);

        string response = "yes";


        while (response == "yes")
        {
            Console.Write("What is your guess?");
            string userInput = Console.ReadLine();
            float guessNumber = float.Parse(userInput);
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Go Lower!");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Go Higher!");
            }
            else
            {
                Console.WriteLine("That's it! You got it!");
                response = "no";
            }
        }

    }
}