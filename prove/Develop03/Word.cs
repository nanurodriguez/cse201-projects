using System;
using System.Runtime.CompilerServices;

public class Word
{

    //Private variables 
    private string _text;
    private bool _isHidden;

    List<Word> _words = new List<Word>();

    //Word Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Hide method will help us hide the words we choose to hide
    public void Hide()
    {
        _text = "______";
    }
    //Show method will help us show the words we choose to show
    public void Show()
    {
    }
    //IsHidden method will help us know the words that were hidden.
    public bool IsHidden()
    {
        return true;
    }

    // Getter and Setter - helping us display the text to the screen
    public string GetDisplayText()
    {
        string[] words = _text.Split(' ');

        foreach (var word in words)
        {
            _words.Add(new Word(word));
        }



        string _currentVerse = "";

        foreach (var item in _words)
        {
            _currentVerse += $" {item._text}";
        }


        return _currentVerse;
    }
}