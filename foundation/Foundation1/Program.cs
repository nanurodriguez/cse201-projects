using System;
using System.Runtime.InteropServices.Marshalling;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        //VIDEO (1)
        Console.WriteLine("Video #1");
        string title1 = "How to use product 1 video";
        string author1 = "By Diego";
        int lenght1 = 60;

        string comments1 = "Alien User - How great! , Alien UserX - How awesome! , Alien UserH - Let's do it! , Alien UserM - WOW!";


        Video video1 = new Video(title1, author1, lenght1, comments1);
        Console.WriteLine(video1.DisplayAll());

        // VIDEO (2)

        Console.WriteLine();

        Console.WriteLine("Video #2");

        Console.WriteLine();

        string title2 = "How to store product 2 ";
        string author2 = "By Alice";
        int lenght2 = 120;

        string comments2 = "Agent001 User - I am trying it next time! , AgentX User - No way I will try this , Agent008 User - Let's go! ";

        Video video2 = new Video(title2, author2, lenght2, comments2);
        Console.WriteLine(video2.DisplayAll());

        //VIDEO(3)
        Console.WriteLine();

        Console.WriteLine("Video #3");

        Console.WriteLine();



        string title3 = "New things about Product xx";
        string author3 = "By Amanda";
        int lenght3 = 180;

        string comments3 = "BlueSky User - no changes in the new product , AnotherSky User - I liked these new changes , PinkSky User - I don't think so";

        Video video3 = new Video(title3, author3, lenght3, comments3);
        Console.WriteLine(video3.DisplayAll());

        //VIDEO(4)
        Console.WriteLine();
        Console.WriteLine("Video #4");
        Console.WriteLine();


        string title4 = "Why Getting CXX0001 products";
        string author4 = "By Shanon";
        int lenght4 = 320;

        string comments4 = "ArchofNoah User - Nice job! , LastArch User - Not worth it! , ArchXX User - I will try it out! , ArchFamily User - This product sounds amazing!";

        Video video4 = new Video(title4, author4, lenght4, comments4);
        Console.WriteLine(video4.DisplayAll());



    }
}