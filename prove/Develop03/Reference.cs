using System;
using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;

    private int _verse;

    private int _endVerse;

    private int _startVerse;// added startVerse- it's not a variable part of the design in the project


    // Starting first Constructor

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //Starting Second Constructor with book, chapter and start and endverse
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string reference1 = $"{_book} {_chapter}:{_verse}";
        return reference1;

    }
    public string GetDisplayText2()
    {
        string reference2 = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return reference2;
    }
}