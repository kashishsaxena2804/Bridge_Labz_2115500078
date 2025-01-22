using System;

class HeightConverter
{
    // Method to convert height in centimeters to feet and inches
    public static void ConvertHeight(double cm)
    {
        // Convert cm to inches (1 inch = 2.54 cm)
        double inches = cm / 2.54;

        // Convert inches to feet and remaining inches
        int feet = (int)(inches / 12);  // 1 foot = 12 inches
        inches = inches % 12;  // Get remaining inches after converting to feet

        // Output the result
        Console.WriteLine($"Your height in cm is {cm} while in feet is {feet} and inches is {inches}");
    }

    // Main method
    public static void Main(string[] args)
    {
        // Ask the user for their height in centimeters
        Console.Write("Enter your height in centimeters: ");
        double heightCm = double.Parse(Console.ReadLine());  // Taking user input

        // Call the ConvertHeight method to convert the height
        ConvertHeight(heightCm);
    }
}
