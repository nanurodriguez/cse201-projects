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
        _isHidden = false; //= at the beginning of the program we show all the characters so we set the first value of _isHidden to false so it won't hide the words until we call the Hide() method

    }

    //if we set the value of _isHidden to = true; then the program will Hide the random words (index) from HideRandomWords
    public void Hide()
    {
        _isHidden = true;
    }
    //If we set the value of _isHidden to = false; then the program will take  Show() = false
    public void Show()
    {
        _isHidden = false;
    }
    //then we return to the _isHidden value to keep working with those values 
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Getter and Setter - If _isHidden took place and an item has been hidden then you should (new string= " __") 
    //this will help us add a new string value then the next parameter is _text.Length which will count the charachters of the word that has been hidden.
    //Finally it will return the current local variable "underline" plus the string- ELSE: if nothing was hidden then it will return the text or current value

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