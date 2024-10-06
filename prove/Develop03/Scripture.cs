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

        string[] words = _text.Split(' '); //split long string into list separated by ' ' (space)

        foreach (var item in words)
        {
            _words.Add(new Word(item)); //create list of objects that will contain (_text, _isHidden = False)
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        //code to hide the random word selected Random
        Random random = new Random();

        int counter = 0; //initiate counter

        do
        {
            int randomNumber = random.Next(_words.Count); //create random number to find
            if (!_words[randomNumber].IsHidden()) //check if list item is already hidden or not
            {
                counter++; //add to counter to show succesful hide of list item.
                _words[randomNumber].Hide(); //hide
                if (IsCompletelyHidden())
                {
                    break;
                }
            }
        } while (counter != numberToHide); //Verify that 3 NEW list items have been hidden. (numberToHide = parameter that takes place in HideRandomWords and that will be used in the program Class: scripture.HideRandomWords(3);)
    }

    // GetDisplayText will make the scripture available for the user
    public string GetDisplayText()
    {
        //Word word = new Word(_text);
        //string _currentVerse = word.GetDisplayText();
        string _currentVerse = ""; //sets the beginning value of the Scripture so we can begin with adding or printing the scripture reference and verse.

        foreach (Word word in _words) //Retrieve Text OR Filler for each index of the list of Objects named _words
        {
            string getText = word.GetDisplayText(); //Whether ___ or Text from Word class, set as string anmed getText
            _currentVerse = _currentVerse + getText; //combine all results into one string to display.
        }

        Console.Clear();
        string scripture1 = $"{_reference.GetDisplayText()} {_currentVerse}.";
        return scripture1;
    }
    // IsCompletelyHidden class will help us know if the scripture was completerly hidden 
    // so the code can quit
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                //if Is Hidden (true) - do nothing
            }
            else
            {
                return false; //If not hidden, then all are not completely hidden
            }

        }
        return true; //For loop completes if all IsHidden and returns true value.
    }
}