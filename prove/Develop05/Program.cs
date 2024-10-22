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
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0, "Get Ready...");

                    breathingActivity.Run();

                    break;

                case "2": // Display Content of ListingActivity
                    List<string> promptListing = ["Who are people that you appreciate?","What are personal strengths of yours?",
                    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, 0, promptListing);
                    listingActivity.Run();
                    break;

                case "3": //Displaying Content of ReflectingActivity
                    List<string> promptList = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];

                    List<string> promptQuestion = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?",
                    "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"];

                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, promptList, promptQuestion);
                    reflectingActivity.Run();

                    break;

                case "4":
                    Console.WriteLine("GoodBye!");
                    break;
                default: // will prompt the user to enter the correct option
                    Console.WriteLine("Incorrect Entry! Please try again by selecting the options 1-4");
                    break;
            }
        }
    }
}