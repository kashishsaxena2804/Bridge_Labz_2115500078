using System;

class DigitCounter
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to count its digits:");

        // Get input and initialize variables
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        // Loop to count digits
        while (number != 0)
        {
            number /= 10;
            count++;
        }

        // Print the result.
        Console.WriteLine($"The number of digits is: {count}");
    }
}
