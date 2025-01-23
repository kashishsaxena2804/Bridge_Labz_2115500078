using System;

class ArmstrongNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to check if it is an Armstrong number:");

        // Get input and initialize variables
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;

        // Loop to calculate the sum of cubes of digits
        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;
            sum += digit * digit * digit;
            originalNumber /= 10;
        }

        // Check if the sum equals the original number
        if (sum == number)
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }
}
