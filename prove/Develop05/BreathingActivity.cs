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
        List<string> breathing = new List<string>();
        breathing.Add("Let's breathe in...");
        breathing.Add("Now let's breathe out...");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string b = breathing[i];
            Console.Write(b);
            Thread.Sleep(5000);
            Console.Write("\b \b");
            i++;

            if (i >= breathing.Count)
            {
                i = 0;
            }

        }

        Console.WriteLine("Done...");

    }


}