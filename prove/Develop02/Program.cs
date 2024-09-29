using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello There! Welcome to YOUR Journal! ");
        Console.WriteLine("I am so glad you returned!");

        Entry entry = new Entry();
        entry.Display();
    }
}