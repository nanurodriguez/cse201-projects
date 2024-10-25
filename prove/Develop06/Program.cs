using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // menu options
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            // if selected then
            string selection = Console.ReadLine();
            //Adding switch for multiple options selection
            string goalName = Console.ReadLine();
            string goalDescription = Console.ReadLine();
            int goalPoints = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case "1":
                    SimpleGoal goal1 = new SimpleGoal(goalName, goalDescription, goalPoints);
                    goal1.GetStringRepresentation();
                    break;

                case "2":
                    EternalGoal goal2 = new EternalGoal(goalName, goalDescription, goalPoints);
                    goal2.RecordEvent();
                    break;

                case "3":
                    int amountTimes = Convert.ToInt32(Console.ReadLine());
                    int target = Convert.ToInt32(Console.ReadLine());
                    int bonus = Convert.ToInt32(Console.ReadLine());
                    ChecklistGoal goal3 = new ChecklistGoal(goalName, goalDescription, goalPoints, amountTimes, target, bonus);
                    goal3.RecordEvent();
                    break;

                default:
                    Console.WriteLine("Incorrect Entry, please try one number from the menu options");
                    break;

            }
        }
    }
}