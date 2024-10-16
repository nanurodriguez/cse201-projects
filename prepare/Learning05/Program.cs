using System;
using System.Net;
class Program
{
    static void Main(string[] args)
    {

        MathAssignment assignment1 = new MathAssignment("Nancy", "Math", "2.0", "10-13");
        Console.WriteLine(assignment1.GetHomeworkList());


        WritingAssignment assignment2 = new WritingAssignment("Maria", "English", "Romeo & Julieta by William Shakespeare");
        Console.WriteLine(assignment2.GetWritingInformation());
        /*
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("Guilliver and the Lilliputs");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook("La caida", "Unknown", "Samantha");
        Console.WriteLine(book2.GetIllustratorInfo());

        Book book3 = new Book("El ocaso", "George Washington");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("George the Big", "Michael", "Angelo da Vinci");
        Console.WriteLine(book4.GetIllustratorInfo());
        */
    }
}