using System;

class OddEvenNumbers {
    public static void Main(string[] args) {
        // Prompt the user for input
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the entered number is a natural number (non-negative)
        if (number < 1) {
            Console.WriteLine("Please enter a positive integer greater than or equal to 1.");
            return;
        }

        Console.WriteLine($"Odd and Even numbers from 1 to {number}:");

        // Loop through numbers from 1 to the entered number
        for (int i = 1; i <= number; i++) {
            if (i % 2 == 0) {
                Console.WriteLine($"{i} is an Even number.");
            } else {
                Console.WriteLine($"{i} is an Odd number.");
            }
        }
    }
}
