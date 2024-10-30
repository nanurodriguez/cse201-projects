using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>();
        int score = 0;
        GoalManager manager = new GoalManager(goalList, score);

        while (true)
        {
            manager.DisplayPlayerInfo();
            // menu options
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Current Goals");
            Console.WriteLine("5. Load Goals");

            // if selected then
            string selection = Console.ReadLine();
            //Adding switch for multiple options selection

            switch (selection)
            {
                case "1": // Create New Goal
                    manager.Start();
                    break;

                case "2": //Record Event
                    manager.RecordEvent();
                    break;

                case "3": //Display Goals
                    manager.ListGoalDetails();
                    break;

                case "4": //Save Current Goals
                    manager.SaveGoals();
                    break;

                case "5": //Load Goals
                    manager.LoadGoals();
                    break;

                default:
                    Console.WriteLine("Incorrect Entry, please try one number from the menu options");
                    break;

            }
        }
    }
}