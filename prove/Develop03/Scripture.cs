using System;

//Scripture: Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    public List<Word> _words = new List<Word>();

    //Constructor of Scripture with 2 parameters: Reference: Reference and text:string
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        //code to hide the random word selected Random
    }

    // GetDisplayText will make the scripture available for the user
    public string GetDisplayText()
    {
        return "GetDisplayText Class";
    }
    // IsCompletelyHidden class will help us know if the scripture was completerly hidden 
    // so the code can quit
    public bool IsCompletelyHidden()
    {
        return true;
    }
}