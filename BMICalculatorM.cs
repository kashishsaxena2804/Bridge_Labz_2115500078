using System;

class BMICalculatorM
{
    public static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        // Multi-dimensional array to store weight, height, and BMI
        double[,] personData = new double[numberOfPersons, 3]; // [numberOfPersons][0=weight, 1=height, 2=BMI]
        string[] weightStatus = new string[numberOfPersons];

        // Input weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}:");

            // Input weight
            do
            {
                Console.Write("Enter weight (kg): ");
                personData[i, 0] = Convert.ToDouble(Console.ReadLine());
                if (personData[i, 0] <= 0)
                    Console.WriteLine("Weight must be a positive value. Try again.");
            } while (personData[i, 0] <= 0);

            // Input height
            do
            {
                Console.Write("Enter height (m): ");
                personData[i, 1] = Convert.ToDouble(Console.ReadLine());
                if (personData[i, 1] <= 0)
                    Console.WriteLine("Height must be a positive value. Try again.");
            } while (personData[i, 1] <= 0);
        }

        // Calculate BMI and determine weight status
        for (int i = 0; i < numberOfPersons; i++)
        {
            // BMI = weight / (height * height)
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);

            // Determine weight status
            if (personData[i, 2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i, 2] >= 18.5 && personData[i, 2] < 24.9)
                weightStatus[i] = "Normal weight";
            else if (personData[i, 2] >= 25 && personData[i, 2] < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obesity";
        }

        // Display results
        Console.WriteLine("\nBMI Report:");
        Console.WriteLine("Person\tWeight(kg)\tHeight(m)\tBMI\t\tWeight Status");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{personData[i, 0]:F2}\t\t{personData[i, 1]:F2}\t\t{personData[i, 2]:F2}\t\t{weightStatus[i]}");
        }
    }
}
