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


    public void GetRandomPrompt(Entry newPrompt)
    {

        Entry prompt1 = new Entry();
        prompt1._promptText = "What did you do today?";
        Entry prompt2 = new Entry();
        prompt2._promptText = "Did you meet someone?";
        Entry prompt3 = new Entry();
        prompt3._promptText = "Let's mention your blessings:";
        Entry prompt4 = new Entry();
        prompt4._promptText = "Did you find something interesting in your scripture reading?";
        Entry prompt5 = new Entry();
        prompt5._promptText = "Mention something you enjoyed doing today:";
        Entry prompt6 = new Entry();
        prompt6._promptText = "Did you learn something new?";

        PromptGenerator prompt = new PromptGenerator();

        prompt._prompts.Add();
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }

}
