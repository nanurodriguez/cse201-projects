using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity("Breathing Excercises", "I don't know yet", 20);
        Console.WriteLine(activity1.DisplayStartingMessage());
    }
}