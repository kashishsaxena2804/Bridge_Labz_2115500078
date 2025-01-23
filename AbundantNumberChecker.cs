using System;

class AbundantNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to check if it is an Abundant number:");

        // Get input and initialize variables
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        // Loop to find divisors and calculate their sum
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)  // Check if 'i' is a divisor
            {
                sum += i;
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            Console.WriteLine($"{number} is an Abundant number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Abundant number.");
        }
    }
}
