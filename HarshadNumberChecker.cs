using System;

class HarshadNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to check if it is a Harshad number:");

        // Get input and initialize variables
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;

        // Calculate the sum of digits
        while (originalNumber != 0)
        {
            sum += originalNumber % 10;  // Add the last digit to sum
            originalNumber /= 10;        // Remove the last digit
        }

        // Check if divisible by sum of digits
        if (number % sum == 0)
        {
            Console.WriteLine($"{number} is a Harshad number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Harshad number.");
        }
    }
}
