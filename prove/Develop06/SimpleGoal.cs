using System;

// SIMPLE GOAL: A Goal that is done once and that's it- example: Visit a friend this weekend <> then the description: explaining what are the requirements and details etc.

public class SimpleGoal : Goal
{
    private bool _isComplete;

    //Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent() // should mark a simple goal complete
    {
        base._isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {base._points}");
    }

    public int GetPoints()
    {
        return base._points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string goalString = $"Simple Goal:{base._name},{base._description},{base._points},{_isComplete}";
        return goalString;
    }
}