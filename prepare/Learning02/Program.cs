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

        Console.WriteLine($"{job1._jobTitle} ({job1._company}) {job1._startYear}-{job1._endYear}");

        Job job2 = new Job();

        job2._company = "Drop-Box";
        job2._jobTitle = "Full Stack Developer";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Console.WriteLine($"{job2._jobTitle} ({job2._company}) {job2._startYear}-{job2._endYear}");
    }
}