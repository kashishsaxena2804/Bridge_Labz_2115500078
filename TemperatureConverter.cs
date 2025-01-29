using System;

class TemperatureConverter
{
    static double ToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
    static double ToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

    static void Main()
    {
        Console.Write("Enter temperature value: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C/F)? ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (choice == 'C')
            Console.WriteLine($"Temperature in Celsius: {ToCelsius(temp):F2}°C");
        else if (choice == 'F')
            Console.WriteLine($"Temperature in Fahrenheit: {ToFahrenheit(temp):F2}°F");
        else
            Console.WriteLine("Invalid choice.");
    }
}
