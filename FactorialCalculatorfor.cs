using System;

class FactorialCalculatorfor {
    public static void Main(string[] args) {
        // Prompt the user for input
        Console.Write("Enter a positive integer to find its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the entered number is positive
        if (number < 0) {
            Console.WriteLine("Please enter a positive integer. Factorial is not defined for negative numbers.");
            return;
        }

        // Initialize the factorial result
        int factorial = 1;

        // Compute the factorial using a for loop
        for (int i = 1; i <= number; i++) {
            factorial *= i; // Multiply factorial by the current value of i
        }

        // Display the result
        Console.WriteLine($"The factorial of {number} is: {factorial}");
    }
}
