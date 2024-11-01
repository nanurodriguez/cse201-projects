using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Excercising App!");

        Activity activity = new Activity("31 Oct 2024", 30);
        Console.WriteLine(activity.GetSummary());

        RunningActivity runningActivity = new RunningActivity("31 Oct 2024", 30, 30);
        CyclingActivity cyclingActivity = new CyclingActivity("31 Oct 2024", 30, 30);
        SwimmingActivity swimmingActivity = new SwimmingActivity("31 Oct 2024", 30, 30);

        string runDisplay = runningActivity.GetSummary();
        string cycleDisplay = cyclingActivity.GetSummary();
        string swimDisplay = swimmingActivity.GetSummary();

        Console.WriteLine(runDisplay);
        Console.WriteLine(cycleDisplay);
        Console.WriteLine(swimDisplay);
    }
}