using System;

class FactorialCalculator {
    public static void Main(string[] args) {
        // Prompt the user for input
        Console.Write("Enter a positive integer to find its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the entered number is positive
        if (number < 0) {
            Console.WriteLine("Please enter a positive integer. Factorial is not defined for negative numbers.");
            return;
        }

        // Initialize variables
        int factorial = 1; // Factorial result starts at 1
        int counter = number; // Counter starts at the user input value

        // Compute the factorial using a while loop
        while (counter > 0) {
            factorial *= counter; // Multiply the current value of counter
            counter--; // Decrement the counter
        }

        // Display the result
        Console.WriteLine($"The factorial of {number} is: {factorial}");
    }
}
