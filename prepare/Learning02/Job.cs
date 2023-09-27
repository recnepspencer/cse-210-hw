public class Job
{
    // Properties
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public static List<Job> JobsList { get; } = new List<Job>();


    public string DisplayJobDetails()
    {
        return $"{JobTitle} at {Company} from {StartYear}-{EndYear}";
    }

    // Constructor
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        Company = company;
        JobTitle = jobTitle;
        StartYear = startYear;
        EndYear = endYear;

        JobsList.Add(this);
    }

}