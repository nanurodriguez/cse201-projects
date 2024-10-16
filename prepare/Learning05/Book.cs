using System;
using System.Net;

public class Book
{
    protected string _author = ""; //protected is accessible to this class and any other class that derives from it
    protected string _title = "";

    public Book()
    {
        _author = "Anonnymous";
        _title = "Unknown";
    }
    public Book(string author, string title)
    {
        _author = author;
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetBookInfo()
    {
        return $"{_title} by {_author} ";
    }
}