using System;

class KilometerToMileConverter
{
    public static void Main(string[] args)
    {
        // Create a variable to store the distance in kilometers
        double km;

        // Ask the user to enter the distance in kilometers
        Console.Write("Enter distance in kilometers: ");
        
        // Take user input and convert it to double
        km = double.Parse(Console.ReadLine());

        // Calculate the distance in miles (1 mile = 1.6 km)
        double miles = km / 1.6;

        // Output the result
        Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
    }
}
