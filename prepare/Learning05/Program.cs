using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("Guilliver");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook("Broock", "Unknown", "Samantha");
        Console.Write(book2.GetBookInfo());
        Console.WriteLine(book2.GetIllustratorInfo());

        Book book3 = new Book("Michael", "Sunday Morning");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("George", "Michael", "Angelo");
        Console.WriteLine(book4.GetBookInfo());
    }
}