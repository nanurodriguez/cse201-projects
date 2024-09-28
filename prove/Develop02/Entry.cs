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

        Console.WriteLine("Hello There! Welcome to YOUR Journal! ");
        Console.WriteLine("I am so glad you returned!");
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(dateText);

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
            //float number = float.Parse(selection);

            //adding switch for multiple options of selection

            switch (selection)
            {
                case "1":
                    journal.GetRandomPrompt();
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    journal.LoadFromFile("myFile.txt");
                    break;

                case "4":
                    journal.SaveToFile("myFile.txt");
                    break;

                case "5":
                    Console.WriteLine("It's okay, Let's write another time!");
                    break;

            }
        }
    }

}