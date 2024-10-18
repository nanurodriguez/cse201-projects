using System;
using System.Data;
using System.Diagnostics;

public class BreathingActivity : Activity

{
    private string _message;
    public BreathingActivity(string name, string description, int duration, string message) : base(name, description, duration)
    {
        _message = message;
    }

    public void Run()
    {
        Console.WriteLine("How many seconds would you like to work on this activity?");
        int intTime = Convert.ToInt32(Console.ReadLine());
        DateTime startIntTime = DateTime.Now;
        DateTime endIntTime = startIntTime.AddSeconds(intTime);

        while (DateTime.Now < endIntTime)
        {
            Console.WriteLine("Get Ready..."); // should be in the program class so then can display the spinner?
            Thread.Sleep(2000);
            List<string> breathing = new List<string>();
            breathing.Add("Let's breathe in...");
            breathing.Add("Now let's breathe out...");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(intTime);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string b = breathing[i];
                Console.Write(b);
                Thread.Sleep(1000);
                for (int count = 5; count > 0; count--)
                {
                    Console.Write(count);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("");
                i++;

                if (i >= breathing.Count)
                {
                    i = 0;
                }

            }
        }
        Thread.Sleep(2000);
        Console.WriteLine($"{"\n"}{DisplayEndingMessage()}{"\n"}");
        Thread.Sleep(2000);

    }


}