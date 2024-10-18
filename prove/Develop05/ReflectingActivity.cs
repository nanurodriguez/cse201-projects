using System;

public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.WriteLine("How many seconds would you like to work on this activity?");
        int duration = Convert.ToInt32(Console.ReadLine());
        DateTime startIntTime = DateTime.Now;
        DateTime endTime = startIntTime.AddSeconds(duration);

        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            base.ShowSpinner(20);
            Thread.Sleep(3000);
            int randomPrompt = random.Next(_prompts.Count);
            Console.WriteLine(randomPrompt);
            Console.WriteLine("When you have something in mind, press Y to continue...");
            Console.ReadLine();
            Console.WriteLine($"Now ponder on each of the following questions as they related to this experience \n");
            Console.Write("You should begin in...");
            Thread.Sleep(1000);
            base.ShowCountDown(5);
            int randomQuestion = random.Next(_questions.Count);
            Console.WriteLine(randomQuestion);
        }

    }
    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }

}