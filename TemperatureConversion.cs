using System;

class TemperatureConversion
{
    public static void Main(string[] args)
    {
        // Input: Prompt the user to enter the temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the formula
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Output the result
        Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult:F2} Fahrenheit.");
    }
}
