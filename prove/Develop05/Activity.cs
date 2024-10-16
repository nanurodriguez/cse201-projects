using System;
using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string DisplayStartingMessage()
    {
        return $"Welcome to {_name}!{"\n"}{_description}{"\n"}It will take {_duration} seconds.";
    }

    public string DisplayEndingMessage()
    {
        return "Goodbye!";
    }
    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }


}