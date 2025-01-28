using System;

class GeneralConverter
{
    public static double ConvertFahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
    public static double ConvertCelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    public static double ConvertPoundsToKg(double pounds) => pounds * 0.453592;
    public static double ConvertKgToPounds(double kg) => kg * 2.20462;
    public static double ConvertGallonsToLiters(double gallons) => gallons * 3.78541;
    public static double ConvertLitersToGallons(double liters) => liters * 0.264172;

    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double f = double.Parse(Console.ReadLine());
        Console.WriteLine($"{f}°F = {ConvertFahrenheitToCelsius(f)}°C");

        Console.Write("Enter weight in pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        Console.WriteLine($"{pounds} lbs = {ConvertPoundsToKg(pounds)} kg");

        Console.Write("Enter volume in gallons: ");
        double gallons = double.Parse(Console.ReadLine());
        Console.WriteLine($"{gallons} gallons = {ConvertGallonsToLiters(gallons)} liters");
    }
}
