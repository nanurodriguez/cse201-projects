using System;
using System.Net;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "student";
        _topic = "topic";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} , {_topic}";
    }




}

/*
public class Book
{
    protected string _author = ""; //protected is accessible to this class and any other class that derives from it
    protected string _title = "";

    public Book()
    {
        _author = "Anonnymous";
        _title = "Unknown";
    }
    public Book(string title, string author)
    {
        _title = title;

        _author = author;
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
*/