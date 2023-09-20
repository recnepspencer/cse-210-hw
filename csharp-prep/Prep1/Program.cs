using System;

class Program
{
    static void Main(string[] args)
    {
        AskForNames();
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

}