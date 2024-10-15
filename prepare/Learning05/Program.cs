using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("Guilliver");

        Console.WriteLine(book1.GetBookInfo());

        Book book2 = new Book();
        book2.SetAuthor("Bell");
        book2.SetTitle("Los Amores");
        Console.WriteLine(book2.GetBookInfo());

    }
}