using System;

//ETERNAL GOAL: it will never get checked off - like reading the scriptures or praying
public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        if (_isComplete == true)
        {
            int newPoints = base._points += _points;
            string completed = "X";

            Console.WriteLine(newPoints);

        }
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        string goalString = $"Eternal Goal:{base._name},{base._description},{base._points}";
        return goalString;
    }
}