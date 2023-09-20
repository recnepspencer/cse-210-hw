using System;

class Program
{
    static void Main(string[] args)
    {
 
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);

    }
    // DisplayWelcome: This method should take in a string and print it out to the console.
    static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the program!");
    }

    // PromptUserName: This method should prompt the user for their name and return it.
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    // PromptUserNumber: This method should prompt the user for a number and return it.
    static int PromptUserNumber()
    {
        int number;
        Console.Write("What is your number? ");

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("What is your number? ");
        }

        return number;
    }

    // SquareNumber: Accepts an integer and squares it
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    // DisplayResult: Accepts the user's name and squared number and returns it.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, your number squared is {squaredNumber}.");
    }
}