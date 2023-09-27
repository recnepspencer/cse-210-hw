using System;
using System.Collections.Generic;

public class Resume 
{
    // Properties 
    public string Name { get; set; }
    public List<Job> Jobs { get; set; }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {Name}");
        foreach (var job in Jobs)
        {
            Console.WriteLine($"Job:{job.DisplayJobDetails()}");
        }
    }

    // Constructor
    public Resume(string name, List<Job> jobs)
    {
        Name = name;
        Jobs = jobs;
    }
}