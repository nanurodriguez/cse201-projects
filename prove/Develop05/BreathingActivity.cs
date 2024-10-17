using System;

public class BreathingActivity : Activity

{
    private string _message;
    public BreathingActivity(string name, string description, int duration, string message) : base(name, description, duration)
    {
        _message = message;
    }

    public void Run()
    {
        //List<string> breathing = ["Breath in", "Breath out"];
    }


}