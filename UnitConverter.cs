using System;

class UnitConverter
{
    public static double ConvertKmToMiles(double km) => km * 0.621371;
    public static double ConvertMilesToKm(double miles) => miles * 1.60934;
    public static double ConvertMetersToFeet(double meters) => meters * 3.28084;
    public static double ConvertFeetToMeters(double feet) => feet * 0.3048;

    static void Main()
    {
        Console.Write("Enter distance in km: ");
        double km = double.Parse(Console.ReadLine());
        Console.WriteLine($"{km} km = {ConvertKmToMiles(km)} miles");

        Console.Write("Enter distance in miles: ");
        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine($"{miles} miles = {ConvertMilesToKm(miles)} km");

        Console.Write("Enter distance in meters: ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {ConvertMetersToFeet(meters)} feet");

        Console.Write("Enter distance in feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {ConvertFeetToMeters(feet)} meters");
    }
}
