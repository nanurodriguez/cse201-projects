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
        Console.WriteLine("Get Ready..."); // should be in the program class so then can display the spinner?
        string[] breathing = ["Let's breathe in...", "Now let's breathe out..."];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string b = breathing[i];
            Console.Write(b);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            string o = breathing[i];
            Console.Write(o);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

        }

        Console.WriteLine("Done...");

    }


}