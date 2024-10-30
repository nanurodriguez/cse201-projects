using System;
//CHECKLISTGOAL: Accomplished a certain number of times: like any goal you would like to do regularly- Walk 30 minutes twice a week- 2times check check
// if you complete the goal (the amount of times set) then you will get a BONUS POINT
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int amount, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()// marking number of times a checklist goal has been completed - returning the points value associated with recording the event
    {
        int currentPoints = base._points;
        if (_amountCompleted == _target)
        {
            _bonus += currentPoints;
            Console.WriteLine("You've got EXTRA POINTS!");
        }

    }

    public override bool IsComplete()
    {

        return _isComplete;

    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        string goalString = $@"Checklist Goal:{base._name},{base._description},{base._points},{_isComplete},{_amountCompleted},{_target},{_bonus}";
        return goalString;
    }
}