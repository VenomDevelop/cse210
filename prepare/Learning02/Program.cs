using System;

class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job();

        myFirstJob._companyName = "Toku";
        myFirstJob._jobTitle = "Software Engineer";
        myFirstJob._startYear = 2019;
        myFirstJob._endYear = 2026;

        myFirstJob.DisplayJob();

        Job mySecondJob = new Job();
        mySecondJob._companyName = "Jimmy Johns";
        mySecondJob._jobTitle = "Inshop";
        mySecondJob._startYear = 2022;
        mySecondJob._endYear = 2026;
        mySecondJob.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "H";
        myResume._jobs = new List<Job>();
        myResume._jobs.Add(myFirstJob);
        myResume._jobs.Add(mySecondJob);

        myResume.DisplayResume();
    }
}