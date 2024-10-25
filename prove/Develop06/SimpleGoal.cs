using System;

// SIMPLE GOAL: A Goal that is done once and that's it- example: Visit a friend this weekend <> then the description: explaining what are the requirements and details etc.

public class SimpleGoal : Goal
{
    private bool _isComplete;

    //Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent() // should mark a simple goal complete
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return @$"What is the name of your goal?{_shortName}{"\n"} 
        What is a short description of it? {_description}{"\n"}
        What is the amount of points associated with this goal?{_points}{"\n"}";
    }
}