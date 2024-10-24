/*
Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
DisplayPlayerInfo - Displays the players current score.
ListGoalNames - Lists the names of each of the goals.
ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
SaveGoals - Saves the list of goals to a file.
LoadGoals - Loads the list of goals from a file.
*/
using System;
public class GoalManager
{
    protected List<Goal> _goals;

    protected int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = 0;
    }
}