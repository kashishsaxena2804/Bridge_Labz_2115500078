using System;

class EarthVolume
{
    public static void Main(string[] args)
    {
        // Radius of Earth in kilometers
        double radiusKm = 6378;

        // Volume formula for a sphere: (4/3) * pi * r^3
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        // Convert volume to cubic miles (1 km^3 = 0.239913 miles^3)
        double volumeMiles3 = volumeKm3 * 0.239913;

        // Print the results
        Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm3 + "The volume of Earth in cubic miles is " + volumeMiles3);
    }
}
