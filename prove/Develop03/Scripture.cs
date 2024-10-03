using System;

//Scripture: Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    //private string _reference;
    public List<Word> _words = new List<Word>();

    public Scripture()
    {

    }

    public string GetDisplayText()
    {
        return "Moses 1:39";
    }
}