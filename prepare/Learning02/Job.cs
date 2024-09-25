

//Class Job Responsabilities: Keeps Track of the company, job title, start year, and end year.
//Behaviors: Display job information in the format "Job Title(Company) StartYear-EndYear"

using System;
using System.Runtime.CompilerServices;

public class Job
{

    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

