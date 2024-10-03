using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;


public class Menu
{

    public void Display()
    {

        while (true)
        {
            //Menu Options given:

            Console.WriteLine("Press Enter to continue or type quit to exit.");

            string selection = Console.ReadLine();
            //float number = float.Parse(selection);

            //adding switch for multiple options of selection

            switch (selection)
            {
                case "1": //Write:Write a new entry - Show the user a random prompt 
                          //(from a list that you create), and save their response, the prompt, and the date as an Entry.

                    Journal.AddEntry();

                    break;

                case "2": // Display Content of an EntryS
                    Journal.DisplayAll();
                    break;

                case "3": // Load file myFile.txt
                    Journal.LoadFromFile("myFile.txt");
                    break;

                case "4":
                    Journal.SaveToFile("myFile.txt");
                    break;

                case "5":
                    Console.WriteLine("It's okay, Let's write another time!");
                    break;
                default: // will prompt the user to enter the correct option
                    Console.WriteLine("Incorrect Entry! Please try again by selecting the options 1-5.");
                    break;
            }
        }
    }

}