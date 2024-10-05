using System;

//Scripture: Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private string _text;
    public List<Word> _words = new List<Word>();



    //Constructor of Scripture with 2 parameters: Reference: Reference and text:string
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

        //Pulls text from Program (scripture verse) and transforms into list named words

        string[] words = _text.Split(' ');

        foreach (var item in words)
        {
            _words.Add(new Word(item));
        }
    }

    public void HideRandomWords()
    {
        //code to hide the random word selected Random
        Random random = new Random();
        int randomNumber1 = random.Next(_words.Count);
        int randomNumber2 = random.Next(_words.Count);
        int randomNumber3 = random.Next(_words.Count);

    }

    // GetDisplayText will make the scripture available for the user
    public string GetDisplayText()
    {
        Word word = new Word(_text);
        string _currentVerse = word.GetDisplayText();

        Console.Clear();
        string scripture1 = $"{_reference.GetDisplayText()} {_currentVerse}.";
        return scripture1;
    }
    // IsCompletelyHidden class will help us know if the scripture was completerly hidden 
    // so the code can quit
    public bool IsCompletelyHidden()
    {
        return true;
    }
}