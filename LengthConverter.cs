using System;

class LengthConverter
{
    public static double ConvertYardsToFeet(double yards) => yards * 3;
    public static double ConvertFeetToYards(double feet) => feet * 0.333333;
    public static double ConvertMetersToInches(double meters) => meters * 39.3701;
    public static double ConvertInchesToMeters(double inches) => inches * 0.0254;
    public static double ConvertInchesToCm(double inches) => inches * 2.54;

    static void Main()
    {
        Console.Write("Enter length in yards: ");
        double yards = double.Parse(Console.ReadLine());
        Console.WriteLine($"{yards} yards = {ConvertYardsToFeet(yards)} feet");

        Console.Write("Enter length in inches: ");
        double inches = double.Parse(Console.ReadLine());
        Console.WriteLine($"{inches} inches = {ConvertInchesToCm(inches)} cm");
    }
}
