using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program! I am glad you are back!");
        while (true)
        {
            //Menu Options given:
            Console.WriteLine("Please select one of the following menu options: ");
            Console.WriteLine("1. Breathing Activity: ");
            Console.WriteLine("2. Listing Activity: ");
            Console.WriteLine("3. Reflection Activity: ");
            Console.WriteLine("4. Quit: ");

            //If selected then:
            Console.WriteLine("What would you like to do? ");
            string selection = Console.ReadLine();
            //float number = float.Parse(selection);

            //adding switch for multiple options of selection

            switch (selection)
            {
                case "1": //Displaying Content of BreathingActivity
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 20, "Get Ready...");

                    breathingActivity.Run();

                    break;

                case "2": // Display Content of ListingActivity
                    ListingActivity listingActivity = new ListingActivity();
                    //listingActivity.Run();
                    break;

                case "3": //Displaying Content of ReflectingActivity
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    //listingActivity.Run();
                    break;

                case "4":
                    Console.WriteLine("GoodBye!");
                    break;
                default: // will prompt the user to enter the correct option
                    Console.WriteLine("Incorrect Entry! Please try again by selecting the options 1-5.");
                    break;
            }
        }
    }
}