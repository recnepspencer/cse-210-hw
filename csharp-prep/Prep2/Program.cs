using System;

class Program
{
    static void Main(string[] args)
    {
        string grade = CalculateGrade(score);
        Console.WriteLine($"Your grade is {grade} ({score}%).");


    }

    static string CalculateGrade(int score)
    {
        // Here we create two arrays. One for the grades and one for the cutoffs.
        string[] grades = {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"};
        int[] cutoffs = {93, 90, 87, 83, 80, 77, 73, 70, 67, 63, 60, 0};

        // Here we loop through the cutoffs and check if the score is greater than or equal to the cutoff. If it is, we return the grade.
        for(int i = 0; i < cutoffs.Length; i++){
            if(score >= cutoffs[i]){
                return grades[i];
            }
        }

        return "There was an error.";
    }

}