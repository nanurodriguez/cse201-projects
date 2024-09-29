using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;

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
    public void AddEntry()
    {
        //Adding entry to journal
        string _prompts = promptGenerator.GetRandomPrompt();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(dateText);
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
        Entry outputFile = new Entry();

        string fileName = "myFile.csv";
        try
        {
            using (System.IO.StreamWriter OutputFile = new System.IO.StreamWriter(fileName, true)) // true means to add the information to the end of the file
            {
                foreach (Entry e in _entries)
                {
                    OutputFile.WriteLine(e._entryText);
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
        string lineJournal = "myFile.csv";
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
