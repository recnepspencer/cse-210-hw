using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Here we call the EnterNumbers method and store the result in a variable.
        List<int> numbers = EnterNumbers();

        // Here we call the Data method and store the result in a variable.
        var data = Data(numbers);

        // Now we can print each value individually
        Console.WriteLine("Lowest Positive Number: " + data.lowestPositiveNumber);
        Console.WriteLine("Highest Number: " + data.highestNumber);
        Console.WriteLine("Sum: " + data.sum);

        List<int> sortedList = GetSortedList(numbers);
        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));
    }

    static List<int> EnterNumbers()
    {
        Console.WriteLine("Enter numbers. Type 0 when finished");
        List<int> numbers = new List<int>();
        int listNumber = -1;

        while (listNumber != 0)
        {
            listNumber = ValidateNumber();
            if (listNumber != 0)
            {
                numbers.Add(listNumber);
            }

        }
        return numbers;


        static int ValidateNumber()
        {
            Console.WriteLine("Enter a number: ");
            int listNumber;


            while (!int.TryParse(Console.ReadLine(), out listNumber))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            return listNumber;
        }
    }
    static (int lowestPositiveNumber, int highestNumber, int sum) Data(List<int> numbers)
    {
        int lowestPositiveNumber = numbers[0];
        int highestNumber = numbers[0];
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number > 0 && number < lowestPositiveNumber)
            {
                lowestPositiveNumber = number;
            }
            if (number > highestNumber)
            {
                highestNumber = number;
            }
            sum += number;
        }

        return (lowestPositiveNumber, highestNumber, sum);
    }

    static List<int> GetSortedList(List<int> numbers)
    {
        List<int> sortedList = new List<int>(numbers);
        sortedList.Sort();
        return sortedList;
    }


}