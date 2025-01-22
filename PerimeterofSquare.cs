using System;

class SquareSideCalculator
{
    // Method to calculate the side length from the perimeter
    public static void CalculateSide(double perimeter)
    {
        // Calculate the side of the square
        double side = perimeter / 4;

        // Output the result
        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
    }

    // Main method to take user input for the perimeter
    public static void Main(string[] args)
    {
        // Declare a variable for perimeter
        double perimeter;

        // Take user input for the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        perimeter = double.Parse(Console.ReadLine());

        // Call the CalculateSide method to compute and display the side length
        CalculateSide(perimeter);
    }
}
