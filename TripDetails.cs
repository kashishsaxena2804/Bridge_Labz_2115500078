using System;

class TripDetails
{
    public static void Main(string[] args)
    {
        // Input: Get user inputs for trip details
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from starting city to via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from via city to destination city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculate total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Output trip details
        Console.WriteLine($"The results of the trip are:");
        Console.WriteLine($"Total Distance: {totalDistance} miles");
        Console.WriteLine($"Average Speed: {averageSpeed:F2} miles/hour");
    }
}
