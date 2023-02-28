using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Ubisoft";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume mineResume = new Resume();

        mineResume._name = "Austin Barnes";

        mineResume._jobs.Add(job1);
        mineResume._jobs.Add(job2);

        mineResume.Display();   
    }
}