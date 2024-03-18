using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "General Manager";
        job1._company = "Piza E Vino Irene";
        job1._startYear = 2019;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Sales Manager";
        job2._company = "The Wild Peach";
        job2._startYear = 2024;
        job2._endYear = 0000;

        Resume myResume = new Resume();
        myResume._name = "Daveson McDivit Birri";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}