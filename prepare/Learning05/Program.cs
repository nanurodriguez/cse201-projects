using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("Guilliver");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Bell");
        book2.SetTitle("Los Amores");
        book2.SetIllustrator("Brookly");
        Console.WriteLine(book2.GetBookInfo());

    }
}