using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("Breathing Excercises", "Let's relax for a moment with this breathing excercise...", 20, "How many Seconds would you like to work on this?");
        Console.WriteLine(activity1.DisplayStartingMessage());


    }
}