using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;
using System.IO;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator promptGenerator;
    //Gets to the {PromptGenerator Class and connects to it}
    public Journal()
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }
    public void AddEntry(Entry newEntry)
    {
        //Adding entry to journal
        string _prompts = promptGenerator.GetRandomPrompt();

    }


    public void GetRandomPrompt()
    {

        PromptGenerator prompts = new PromptGenerator();
        string[] strings = {
            "What did you do today?", "Did you meet someone interesting?",
         "Let's mention your blessings:", "Did you find something interesting in your scripture reading?",
         "Mention something you enjoyed doing today:","Did you learn something new?"
        };

    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        //Console message showing that is saving to the file:
        Console.WriteLine("Saving to file 'myFile.txt'... ");

        string fileName = "myFile.txt";
        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry e in _entries)
                {
                    outputFile.WriteLine(e._promptText);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exceptio: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

    }
    public void LoadFromFile(string file)
    {
        string lineJournal = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(lineJournal);
        try
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exceptio: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }


    }

}
