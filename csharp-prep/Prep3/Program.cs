using System;

class Program
{
    static void Main(string[] args)
    {

        Loops();

    }

    static void Loops()
    {
        Random random = new Random();

        Console.WriteLine("The computer will pick a number between 1 and 100. Try to guess it!");
        int magicNumber = random.Next(1, 101);

        int guess = -1;
        int guesses = 0;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");

            try
            {
                guess = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            guesses++;
        }

        Console.WriteLine($"You got it in {guesses} guesses!");
    }

}