using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade Percentage? ");
        string userInput = Console.ReadLine();
        float grade = float.Parse(userInput);

        if (grade < 60)
        {
            Console.WriteLine("You have an F and have failed the class, I am so sorry!! :( ");
        }
        else if (grade > 60 && grade < 70 || grade == 60)
        {
            Console.WriteLine("You have a D. :o Please you can do better than this");
        }
        else if (grade > 70 && grade < 80 || grade == 70)
        {
            Console.WriteLine("You have a C");
            Console.WriteLine("You passed!!");
        }
        else if (grade > 80 && grade < 90 || grade == 80)
        {
            Console.WriteLine("You have a B. WELL DONE!");
        }
        else
        {
            Console.WriteLine("Wait What??? You got an A!! You are AWESOME!!!");
        }
    }
}