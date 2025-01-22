using System;

class BasicCalculator
{
    // Method to perform all the arithmetic operations
    public static void PerformOperations(double number1, double number2)
    {
        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;

        // Check if the second number is zero to avoid division by zero
        double division = (number2 != 0) ? (number1 / number2) : double.NaN;

        // Print the results
        Console.WriteLine($"The addition, subtraction, multiplication, and division values of {number1} and {number2} are:");
        Console.WriteLine($"Addition: {addition}");
        Console.WriteLine($"Subtraction: {subtraction}");
        Console.WriteLine($"Multiplication: {multiplication}");
        Console.WriteLine($"Division: {(double.IsNaN(division) ? "undefined (cannot divide by zero)" : division.ToString())}");
    }

    // Main method
    public static void Main(string[] args)
    {
        // Declare variables for user inputs
        double number1, number2;

        // Take user input for the first number
        Console.Write("Enter the first number: ");
        number1 = double.Parse(Console.ReadLine());

        // Take user input for the second number
        Console.Write("Enter the second number: ");
        number2 = double.Parse(Console.ReadLine());

        // Call the PerformOperations method to perform the calculations
        PerformOperations(number1, number2);
    }
}
