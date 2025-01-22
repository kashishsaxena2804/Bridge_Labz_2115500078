using System;

class DistanceConverter
{
    // Method to calculate yards and miles from feet
    public static void ConvertDistance(double distanceInFeet)
    {
        // Conversion formulas
        double distanceInYards = distanceInFeet / 3;          // 1 yard = 3 feet
        double distanceInMiles = distanceInYards / 1760;      // 1 mile = 1760 yards

        // Output the results
        Console.WriteLine($"The distance in yards is {distanceInYards} yards.");
        Console.WriteLine($"The distance in miles is {distanceInMiles} miles.");
    }

    // Main method to take user input for the distance in feet
    public static void Main(string[] args)
    {
        // Declare a variable for the distance in feet
        double distanceInFeet;

        // Take user input for the distance in feet
        Console.Write("Enter the distance in feet: ");
        distanceInFeet = double.Parse(Console.ReadLine());

        // Call the ConvertDistance method to compute and display the result
        ConvertDistance(distanceInFeet);
    }
}
