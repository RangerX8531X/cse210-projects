using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Electrical Engineer";
        job1._company = "Raytheon";
        job1._startYear = 2025;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Flex Manager";
        job2._company = "Shepherd Univeristy";
        job2._startYear = 2019;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Jacob Swift";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}