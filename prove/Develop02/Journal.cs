using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
public class Journal
{
    //Creating a list for the new entries.
    public List<Entry> _entries = new List<Entry>();
    // creating a variable for date and prompt
    public string date = "Date";
    public string prompt = " - Prompt";

    public void AddEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = "Date: " + theCurrentTime.ToShortDateString();
        PromptGenerator prompt = new PromptGenerator();
        string currentPrompt = " - Prompt: " + prompt.GetRandomPrompt();
        Console.WriteLine(dateText + currentPrompt);

        string newEntry = Console.ReadLine();

        //Adding a new instance: Journal

        Journal saveEntry = new Journal();

        saveEntry._entries.Add(new Entry { _date = dateText, _promptText = currentPrompt, _entryText = newEntry });

        SaveToFile(_entries);
    }
    // Every time the user enters an entry the app will get the date and the prompt text and then display it in the console.

    public void DisplayAll(Entry newEntry)
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e._date + e._promptText);
            Console.WriteLine(e._entryText);
        }
    }

    // adding entries, date, prompt text and entry text to the myFile.csv

    public static LoadFromFile(string file)
    {
        Console.WriteLine("Reading this from File...");
        List<string> readList = new List<string>();
        string lineJournal = "myFile.csv";
        string[] lines = System.IO.File.ReadAllLines(lineJournal);

        //try
        {
            foreach (string line in lines)
            {
                //readList.Add(line);
                //Console.WriteLine(line);
                string[] parts = line.Split(",");
                //Loading each part of the journal
                Entry anotherEntry = new Entry();
                anotherEntry._date = parts[0];
                anotherEntry._promptText = parts[1];
                anotherEntry._entryText = parts[2];
            }
            return readList;
        }

        /*catch (Exception e)
        {
            Console.WriteLine($"Exceptio: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

        
                        if (line.StartsWith(date))
                        {
                            string dateText = line;
                        }
                        else if (line.StartsWith(prompt))
                        {
                            string currentPrompt = line;
                        }
                        else
                        {
                            string newEntry = line;
                        }
                //
        */
    }

    public void SaveToFile(List<Entry> _entries)
    {
        //Console message showing that is saving to the file:
        Console.WriteLine("Saving to file 'myFile.csv'... ");

        string fileName = "myFile.csv";
        try
        {
            using (System.IO.StreamWriter OutputFile = new System.IO.StreamWriter(fileName, true)) // true means to add the information to the end of the file
            {
                foreach (Entry e in _entries)
                {
                    OutputFile.WriteLine(e._date);
                    OutputFile.WriteLine(e._promptText);
                    OutputFile.WriteLine(e._entryText);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Saved.");
        }

    }

}
