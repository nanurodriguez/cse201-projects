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
            base.DisplayStartingMessage();
            base.ShowSpinner(1);
            Thread.Sleep(1000);
            Console.Clear();
            GetRandomPrompt();//Random prompt
            Console.WriteLine("When you have something in mind, press ENTER to continue...");
            Console.ReadLine();
            Console.WriteLine($"Now ponder on each of the following questions as they related to this experience \n");
            Console.Write("You should begin in...");
            Thread.Sleep(1000);
            base.ShowCountDown(2);
            Console.SetCursorPosition(0, Console.CursorTop);
            GetRandomQuestion();//1st Random question
            base.ShowSpinner(1);
            Console.SetCursorPosition(0, Console.CursorTop);
            GetRandomQuestion();//2nd Random question
            base.ShowSpinner(1);
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }

    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Count); //RANDOM PROMPT

        Console.WriteLine(_prompts[randomPrompt]);


    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int randomQuestion = random.Next(_questions.Count); //RANDOM QUESTION
        Console.WriteLine(_questions[randomQuestion]);
    }
    public string DisplayPrompt()
    {
        return "";
    }

    public string DisplayQuestion()
    {
        return "";
    }

}