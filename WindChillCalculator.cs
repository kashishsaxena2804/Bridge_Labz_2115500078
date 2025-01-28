using System;

class WindChillCalculator
{
    public static double CalculateWindChill(double temp, double windSpeed)
    {
        return 35.74 + (0.6215 * temp) + ((0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16));
    }

    static void Main(string[] args)
    {
        Console.Write("Enter temperature (°F): ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed (mph): ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double windChill = CalculateWindChill(temp, windSpeed);
        Console.WriteLine($"Wind Chill Temperature: {windChill:F2}°F");
    }
}
