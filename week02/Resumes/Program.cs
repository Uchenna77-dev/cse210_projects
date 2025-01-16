using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022 );
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        Job job2 = new Job("Apple", "Manager", 2022, 2023);
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Console.WriteLine($" {job1._jobTitle} (Microsoft) {job1._startYear}-{job1._endYear}");
        //Console.WriteLine($" {job2._jobTitle} (Apple) {job2._startYear}-{job2._endYear}");

    
        Resume myResume = new Resume("Allison Rose");
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine($"{myResume._jobs[0]._jobTitle}");
    
        myResume.DisplayResume();

    }

    
}