using System;
using System.Runtime.InteropServices.Marshalling;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        string title1 = "How to use product 1 video";
        string author1 = "Author";
        int lenght1 = 60;

        string comments1 = "Alien User - How great! , Alien UserX - How awesome! , Alien UserH - Let's do it! , Alien UserM - WOW!";


        Video video1 = new Video(title1, author1, lenght1, comments1);
        Console.WriteLine(video1.DisplayAll());
    }
}


//Outcome:

/* 

the program should iterate through the list of videos and 
for each one, display the title, author, length, number 
of comments (from the method) and then list out all of 
the comments for that video. Repeat this display 
for each video in the list.

"How to use product 1 video" - By Alice - 2 minutes (list)
Comments: (# of comments)
- Alien User - "How great!"
- Alien UserX- "How awesome!"
- Alien UserH - "Let's do it!"
- Alien UserM- "WOW!"
"How to store product 2 video" - By Diego - 3 minutes (list)
Comments: (# of comments)
- Alien User - "How great!"
- Alien UserX- "How awesome!"
- Alien UserH - "Let's do it!"
- Alien UserM- "WOW!"
"Get more out of your product 3" - By Maria - 4 minutes (list)
Comments: (# of comments)
- Alien User - "How great!"
- Alien UserX- "How awesome!"
- Alien UserH - "Let's do it!"
- Alien UserM- "WOW!"

*/
