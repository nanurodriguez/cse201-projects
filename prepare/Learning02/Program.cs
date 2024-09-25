using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Adobe";
        job1._jobTitle = "Junior Front-End Developer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Console.WriteLine(job1._company);
    }
}