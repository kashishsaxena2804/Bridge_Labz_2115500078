using System;

class DigitFrequency
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Array to store frequency of digits (0-9)
        int[] frequency = new int[10];

        // Count frequency of each digit
        foreach (char digit in input)
        {
            if (char.IsDigit(digit))
            {
                frequency[digit - '0']++;
            }
            else
            {
                Console.WriteLine("Invalid input! Only numeric values are allowed.");
                return;
            }
        }

        // Display frequency
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digit {i}: {frequency[i]}");
        }
    }
}
