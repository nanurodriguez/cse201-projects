//Class Resume Responsabilities: Keeps track of the person's name and the list of their jobs.
// Behaviors: Displays the resume, which shows the name first, followed by displaying each one of the jobs.

using System;

public class Resume
{
    public string _name;
    public List<Job> _listJobs = new List<Job>();

    public void DisplayFakeResume()
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