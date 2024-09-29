using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;


public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Journal Journal = new Journal();

        while (true)
        {
            //Menu Options given:

            Console.WriteLine("1. Write: ");
            Console.WriteLine("2. Display: ");
            Console.WriteLine("3. Load: ");
            Console.WriteLine("4. Save: ");
            Console.WriteLine("5. Quit: ");

            //If selected then:
            Console.WriteLine("What would you like to do? ");
            string selection = Console.ReadLine();
            //float number = float.Parse(selection);

            //adding switch for multiple options of selection

            switch (selection)
            {
                case "1":
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = "Date: " + theCurrentTime.ToShortDateString();
                    PromptGenerator prompt = new PromptGenerator();
                    string currentPrompt = " - Prompt: " + prompt.GetRandomPrompt();
                    Console.WriteLine(dateText + currentPrompt);

                    string newEntry = Console.ReadLine();

                    Journal._entries.Add(new Entry { _date = dateText, _promptText = currentPrompt, _entryText = newEntry });

                    break;

                case "2":
                    Journal.DisplayAll();
                    break;

                case "3":
                    Journal.LoadFromFile("myFile.txt");
                    break;

                case "4":
                    Journal.SaveToFile("myFile.txt");
                    break;

                case "5":
                    Console.WriteLine("It's okay, Let's write another time!");
                    break;
            }
        }
    }

}