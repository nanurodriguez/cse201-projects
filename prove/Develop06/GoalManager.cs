
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
public class GoalManager
{
    protected List<Goal> _goals;
    public List<string> _referenceList = new List<string>();

    protected int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = 0;
    }


    public void Start()//This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    {
        bool keeplooping = true;
        while (keeplooping == true)
        {
            // menu options
            Console.Clear();
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            // if selected then
            string selection = Console.ReadLine();
            //Adding switch for multiple options selection

            switch (selection)
            {
                case "1":
                    string goal = "Simple Goal";
                    CreateGoal(goal);
                    keeplooping = false;
                    break;

                case "2":
                    //EternalGoal goal2 = new EternalGoal(goalName, goalDescription, goalPoints);
                    //goal2.RecordEvent();
                    string goal1 = "Eternal Goal";
                    CreateGoal(goal1);
                    keeplooping = false;
                    break;

                case "3":
                    /*int amountTimes = Convert.ToInt32(Console.ReadLine());
                    int target = Convert.ToInt32(Console.ReadLine());
                    int bonus = Convert.ToInt32(Console.ReadLine());
                    ChecklistGoal goal3 = new ChecklistGoal(goalName, goalDescription, goalPoints, amountTimes, target, bonus);
                    goal3.RecordEvent();*/
                    string goal2 = "Checklist Goal";
                    CreateGoal(goal2);
                    keeplooping = false;
                    break;

                default:
                    Console.WriteLine("Incorrect Entry, please try one number from the menu options");
                    break;

            }
        }
    }

    public void DisplayPlayerInfo()//Displays the players current score.
    {
        Console.WriteLine(@$"You're current score is: {_score}");
    }
    public void ListGoalNames()//Lists the names of each of the goals.
    {
        foreach (var item in _referenceList)
        {
            Console.WriteLine(item);
        }


    }
    public void ListGoalDetails()//Lists the details of each goal (including the checkbox of whether it is complete).
    {
        Console.WriteLine("The goals are: \n");
        //_referenceList = ["Simple Goal:Ir a la capilla,levantarme de la cama,100,false"];
        int counter = 1;
        foreach (var item in _referenceList) // adding all the items from the goal to a list by separating them with : and a coma 
        {
            string[] type = item.Split(':');
            if (type[0] == "Simple Goal")
            {
                string[] section = type[1].Split(',');
                string _goalName = section[0];
                string _goalDescription = section[1];
                int _goalPoints = Convert.ToInt32(section[2]);
                bool _isComplete = Convert.ToBoolean(section[3]);
                string finished = " ";
                if (_isComplete == true)
                {
                    finished = "X";
                }
                else
                {
                    finished = " ";
                }
                Console.WriteLine($"{counter}. [{finished}] {_goalName} ({_goalDescription})\n");
            }
            else if (type[0] == "Eternal Goal")
            {
                string[] section = type[1].Split(',');
                string _goalName = section[0];
                string _goalDescription = section[1];
                int _goalPoints = Convert.ToInt32(section[2]);
                bool _isComplete = Convert.ToBoolean(section[3]);
                string finished = " ";
                if (_isComplete == true)
                {
                    finished = "X";
                }
                else
                {
                    finished = " ";
                }
                Console.WriteLine($"{counter}. [{finished}] {_goalName} ({_goalDescription})\n");
            }
            else // CHECKLIST GOAL
            {
                string[] section = type[1].Split(',');
                string _goalName = section[0];
                string _goalDescription = section[1];
                int _goalPoints = Convert.ToInt32(section[2]);
                bool _isComplete = Convert.ToBoolean(section[3]);
                int _amountCompleted = Convert.ToInt32(section[4]);
                int _target = Convert.ToInt32(section[5]);
                int _bonus = Convert.ToInt32(section[6]);
                string finished = " ";
                if (_isComplete == true)
                {
                    finished = "X";
                }
                else
                {
                    finished = " ";
                }
                Console.WriteLine($"{counter}. [{finished}] {_goalName} ({_goalDescription}) -- Currently Completed: {_amountCompleted} / {_target} => Bonus Points Gained: {_bonus} \n");
            }
            counter++;
        }
    }

    public void CreateGoal(string goal)//Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        string goalType = goal;

        if (goalType == "Simple Goal")
        {
            Console.WriteLine("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string goalDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int goalPoints = Convert.ToInt32(Console.ReadLine());

            SimpleGoal goal1 = new SimpleGoal(goalName, goalDescription, goalPoints);
            string goalDisplay = goal1.GetStringRepresentation(); //display string that will be broken down into parts (name, description, points, etc. after.)
            Console.WriteLine(goalDisplay);
            _referenceList.Add(goalDisplay);
        }
        else if (goalType == "Eternal Goal")
        {
            Console.WriteLine("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string goalDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int goalPoints = Convert.ToInt32(Console.ReadLine());

            EternalGoal goal1 = new EternalGoal(goalName, goalDescription, goalPoints);
            string goalDisplay = goal1.GetStringRepresentation();
            Console.WriteLine(goalDisplay);
            _referenceList.Add(goalDisplay);
        }
        else
        {
            Console.WriteLine("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string goalDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int goalPoints = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many times would you like to reach this goal?");
            int targetTimes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What is the amount of bonus points once you complete the goal {targetTimes}?");
            int bonusPoints = Convert.ToInt32(Console.ReadLine());

            ChecklistGoal goal1 = new ChecklistGoal(goalName, goalDescription, goalPoints, 0, targetTimes, bonusPoints);
            string goalDisplay = goal1.GetStringRepresentation();
            Console.WriteLine(goalDisplay);
            _referenceList.Add(goalDisplay);
        }


    }

    public void RecordEvent()//Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        // Displays the goals already saved and then The user selects the goal that they would like to work on and then 
        // it will ask the user which goal they have accomplished.
        // then it will call the RecordEvent() from the goal the user selected
        Console.WriteLine("What goal did you work on today?");
        //ListGoalDetails();
        //_referenceList = ["Simple Goal:Ir a la capilla,levantarme de la cama,100,false"];
        int counter = 1;
        foreach (var item in _referenceList) // recording points and number of times they have done the task
        {
            string[] data = item.Split(':');
            string[] section = data[1].Split(',');
            Console.WriteLine($"{counter}- {section[0]}"); //printing only the name of the goal
            counter++;
        }
        int selectGoal = Convert.ToInt32(Console.ReadLine());

        var itemSelected = _referenceList[selectGoal - 1];
        string[] dataSelected = itemSelected.Split(':');
        //string[] sectionSelected = dataSelected[1].Split(',');

        if (dataSelected[0] == "Simple Goal")
        {
            string[] section = dataSelected[1].Split(',');
            string _goalName = section[0];
            string _goalDescription = section[1];
            int _goalPoints = Convert.ToInt32(section[2]);
            bool _isComplete = Convert.ToBoolean(section[3]);

            SimpleGoal simpleGoal = new SimpleGoal(_goalName, _goalDescription, _goalPoints);
            simpleGoal.RecordEvent();
            _score += simpleGoal.GetPoints();
            Console.WriteLine($"You now have {_score} points)\n");
        }
        else if (dataSelected[0] == "Eternal Goal")
        {
            string[] section = dataSelected[1].Split(',');
            string _goalName = section[0];
            string _goalDescription = section[1];
            int _goalPoints = Convert.ToInt32(section[2]);
            bool _isComplete = Convert.ToBoolean(section[3]);
            string finished = " ";
            if (_isComplete == true)
            {
                finished = "X";
            }
            else
            {
                finished = " ";
            }
            Console.WriteLine($"{counter}. [{finished}] {_goalName} ({_goalDescription})\n");
        }
        else // CHECKLIST GOAL
        {
            string[] section = dataSelected[1].Split(',');
            string _goalName = section[0];
            string _goalDescription = section[1];
            int _goalPoints = Convert.ToInt32(section[2]);
            bool _isComplete = Convert.ToBoolean(section[3]);
            int _amountCompleted = Convert.ToInt32(section[4]);
            int _target = Convert.ToInt32(section[5]);
            int _bonus = Convert.ToInt32(section[6]);
            string finished = " ";
            if (_isComplete == true)
            {
                finished = "X";
            }
            else
            {
                finished = " ";
            }
            Console.WriteLine($"{counter}. [{finished}] {_goalName} ({_goalDescription}) -- Currently Completed: {_amountCompleted} / {_target} => Bonus Points Gained: {_bonus} \n");
        }

        Console.WriteLine("Done!");



    }
    public void SaveGoals()//Saves the list of goals to a file.
    {
        string fileName = "GoalList.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (var item in _referenceList)
            {
                outputFile.WriteLine(item);
            }

        }

    }

    public void LoadGoals()//Loads the list of goals from a file.
    {
        string filename = "GoalList.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _referenceList = [];
            _referenceList.Add(line);
        }
    }
}