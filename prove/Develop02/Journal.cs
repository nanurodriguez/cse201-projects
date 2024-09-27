using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

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
        //Adding entry
        string _prompts = promptGenerator.GetRandomPrompt();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(theCurrentTime);

    }


    public void GetRandomPrompt()
    {

        PromptGenerator prompt = new PromptGenerator();
        string[] strings = {
            "What did you do today?", "Did you meet someone interesting?",
         "Let's mention your blessings:", "Did you find something interesting in your scripture reading?",
         "Mention something you enjoyed doing today:","Did you learn something new?".
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

    }
    public void LoadFromFile(string file)
    {

    }

}
