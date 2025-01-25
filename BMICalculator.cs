using System;

class BMICalculator
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of persons: ");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());
        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] statuses = new string[numberOfPersons];

        // Input weight and height
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Enter weight of person {i + 1} (in kg): ");
            weights[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter height of person {i + 1} (in meters): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());

            // Validate inputs
            if (weights[i] <= 0 || heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive values.");
                i--; // Retry for invalid input
                continue;
            }

            // Calculate BMI
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            // Determine status
            if (bmis[i] < 18.5)
                statuses[i] = "Underweight";
            else if (bmis[i] < 24.9)
                statuses[i] = "Normal weight";
            else if (bmis[i] < 29.9)
                statuses[i] = "Overweight";
            else
                statuses[i] = "Obesity";
        }

        // Display results
        Console.WriteLine("\nBMI Results:");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Person {i + 1}: Weight = {weights[i]} kg, Height = {heights[i]} m, BMI = {bmis[i]:F2}, Status = {statuses[i]}");
        }
    }
}
