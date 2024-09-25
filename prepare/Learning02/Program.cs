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

        Job job2 = new Job();

        job2._company = "Drop-Box";
        job2._jobTitle = "Full Stack Developer";
        job2._startYear = 2022;
        job2._endYear = 2024;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
    }
}