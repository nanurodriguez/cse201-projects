using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Journal journal = new Journal();

        Console.WriteLine("Hello There! I am so glad you returned!");
        Console.WriteLine("Welcome to YOUR Journal! ");

        while (true)
        {
            //Menu Options given:

            Console.WriteLine("1. Write: ");
            Console.WriteLine("2. Display: ");
            Console.WriteLine("3. Load: ");
            Console.WriteLine("4. Save: ");
            Console.WriteLine("5. Quit: ");

            //If selected then:

            string selection = Console.ReadLine();
            float number = float.Parse(selection);

            if (selection == "1")
            {
                journal.GetRandomPrompt();

            }
            else if (selection == "2")
            {
                journal.DisplayAll();
            }
            else if (selection == "3")
            {
                journal.LoadFromFile();
            }
            else if (selection == "4")
            {
                journal.SaveToFile();
            }
            else
            {
                Console.WriteLine("It's okay, Let's write in another moment!");
            }
        }
    }

}