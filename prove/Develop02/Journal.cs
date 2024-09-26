using System.Xml.Serialization;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        Console.WriteLine(_listJobs);

        foreach (Job job in _listJobs)
        {
            job.DisplayFakeResume();
        }
    }
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