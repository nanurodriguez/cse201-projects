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
        _isHidden = true;
    }
    //Show method will help us show the words we choose to show
    public void Show()
    {
        _isHidden = false;
    }
    //IsHidden method will help us know the words that were hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Getter and Setter - helping us display the text to the screen
    public string GetDisplayText()
    {
        if (_isHidden) //check if item from list is currently hidden.
        {
            string underline = new string('_', _text.Length); // If hidden from HideRandomWords(), show visually that it is hidden by changing letters to _
            return underline + " ";
        }
        else
        {
            return $"{_text} "; //If not hidden, return text/current item value.
        }
    }
}