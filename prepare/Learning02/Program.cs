using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job("Microsoft", "Software Engineer", 2012, 2013);
        Job job2 = new Job("Google", "Software Engineer", 2013, 2017);
        Job job3 = new Job("Amazon", "Software Engineer", 2017, 2023);

        foreach (var job in Job.JobsList)
        {
            Console.WriteLine(job.DisplayJobDetails());
        }

        Resume resume1 = new Resume("John Doe", Job.JobsList);
        resume1.DisplayResume();

    }
}


