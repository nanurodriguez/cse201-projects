using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Entry
{
    public string __date;
    public string _promptText;
    public string _entryText;
    DateTime today = DateTime.Now;

    // Console.WriteLine(today.ToString("dd/MM/yyyy"));

    //Creating the prompts(questions etc)
    Entry text1 = new Entry();

    text1._promptText = "How was your day today?";

    Entry text2 = new Entry();

    text2._promptText = "Did you meet new people? How was it?";


    
    //Adding a new instance: Journal

    Journal addingEntry = new Journal();

    //Adding questions to the Journal

    addingEntry._promptText.Add(text1);
    addingEntry._promptText.Add(text2);

    addingEntry.AddEntry();


    public void Display()
    {

    }

}