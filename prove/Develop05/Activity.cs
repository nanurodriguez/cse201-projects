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

        return $"Welcome to {_name}!{"\n"}{_description}{"\n"}";
    }

    public string DisplayEndingMessage()
    {
        return " Done! I hope you enjoyed this Activity my friend!";
    }
    public void ShowSpinner(int seconds)
    {

        List<string> animationStrings = new List<string>();
        animationStrings.Add("("); //(~‾⌣‾)~
        animationStrings.Add("~");
        animationStrings.Add("‾");
        animationStrings.Add("⌣");
        animationStrings.Add("‾");
        animationStrings.Add(")");
        animationStrings.Add("~");
        animationStrings.Add("~");//~(‾⌣‾~)
        animationStrings.Add("(");
        animationStrings.Add("‾");
        animationStrings.Add("⌣");
        animationStrings.Add("‾");
        animationStrings.Add("~");
        animationStrings.Add(")");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.WriteLine(s);
            Thread.Sleep(1000);
            Console.WriteLine("\b \b \b \b \b \b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }


        Console.WriteLine("Spinner Ended");

    }

    public void ShowCountDown(int seconds)
    {
        int i = 0;

        for (i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }

        Console.WriteLine("The Count Down Ended");
    }


}