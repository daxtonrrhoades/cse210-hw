using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Teller";
        job1._company = "America First Credit Union";
        job1._startYear = 2023;
        job1._endYear = 2028;

        Job job2 = new Job();
        job2._jobTitle = "Sales Associate";
        job2._company = "Old Navy";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Daxton Rhoades";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}