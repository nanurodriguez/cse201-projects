using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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


        //Adding a new instance: Resume

        Resume fakeResume = new Resume();

        //Adding name to fake resume

        fakeResume._name = "Nancy Rodriguez";

        //Adding  job description to the Fake Resume

        fakeResume._listJobs.Add(job1);
        fakeResume._listJobs.Add(job2);

        fakeResume.DisplayFakeResume();

    }
}