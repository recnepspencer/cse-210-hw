using System;

class Program
{
    static void Main(string[] args)
    {
        AskForNames();

        Console.WriteLine("What is your score?");
        int score = int.Parse(Console.ReadLine());

        string grade = CalculateGrade(score);
        Console.WriteLine($"Your grade is {grade} ({score}%).");

    }

    static void AskForNames(){
        // Here we ask for the first name. We dont do write line because we want the user to type on the same line as the question.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Here we ask for the last name. We dont do write line because we want the user to type on the same line as the question.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Here we print out the name.
        Console.WriteLine($"Your name is {firstName} {lastName}.");
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