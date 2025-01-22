using System;

class TriangleAreaCalculator
{
    // Method to calculate the area of a triangle in square inches and square centimeters
    public static void CalculateArea(double baseLength, double height)
    {
        // Area of the triangle in square centimeters
        double areaInCm2 = 0.5 * baseLength * height;
        
        // Convert area to square inches (1 square inch = 6.4516 square cm)
        double areaInInches2 = areaInCm2 / 6.4516;

        // Output the results
        Console.WriteLine($"The area of the triangle is {areaInCm2} square centimeters and {areaInInches2} square inches.");
    }

    // Main method to take user input for base and height
    public static void Main(string[] args)
    {
        // Declare variables for base and height
        double baseLength, height;

        // Take user input for base of the triangle
        Console.Write("Enter the base of the triangle (in cm): ");
        baseLength = double.Parse(Console.ReadLine());

        // Take user input for height of the triangle
        Console.Write("Enter the height of the triangle (in cm): ");
        height = double.Parse(Console.ReadLine());

        // Call the CalculateArea method to compute and display the area
        CalculateArea(baseLength, height);
    }
}
