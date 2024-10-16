using System;
using System.Net;


public class MathAssignment : Assignment
{

    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()} {"\n"} Section: {_textBookSection}   Problems: {_problems}";
    }



}
/*
public class PictureBook : Book // Picture Book is a BOOK
{

    private string _illustrator = "";

    public PictureBook(string title, string author, string illustrator) : base(title, author)
    {
        _illustrator = illustrator;
    }
    public string GetIllustrator()
    {
        return _illustrator;
    }
    public void SetIllustrator(string illustrator)
    {
        _illustrator = illustrator;
    }

    public string GetIllustratorInfo()
    {

        return $"{_title} by {_author} illustrated by {_illustrator}";
    }




}
*/