using System;

class TriangularPark
{
    public static void Main(string[] args)
    {
        // Input: Prompt the user to enter the sides of the triangular park
        Console.Write("Enter side 1 of the park (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 of the park (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 of the park (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the park
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds to complete 5 km
        double totalDistance = 5000; // 5 km in meters
        double rounds = totalDistance / perimeter;

        // Output the result
        Console.WriteLine($"The total number of rounds the athlete will run is {Math.Ceiling(rounds)} to complete 5 km.");
    }
}
