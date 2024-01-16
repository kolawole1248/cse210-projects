using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "software Engineer";
        job1._company = "Meta";
        job1._startyear = 2023;
        job1._endyear = 2024;

        job job2 = new job();
        job2._jobTitle ="Manager";
        job2._company ="Apple";
        job2._startyear = 2023;
        job2._endyear= 2024;

        Resume myResume = new Resume();
        myResume._name = "Kolawole Uthman";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();

    }
}