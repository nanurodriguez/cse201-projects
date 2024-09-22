using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); //First Function
        string userName = PromptUserName();//Second Function

        int userNumber = PromptUserNumber();//Third Function

        int squaredNumber = SquareNumber(userNumber);//Forth Function

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.Write("Welcome to the Program! ");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your full name: ");
        string Uname = Console.ReadLine();
        return Uname;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int userInput = int.Parse(Console.ReadLine()); //when asking for an integer from the user
        return userInput;
    }
    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;
        return square;
    }
    static void DisplayResult(string userInput, int square)
    {
        Console.Write($"{userInput}, the square of your favorite number is {square}");
    }

}
