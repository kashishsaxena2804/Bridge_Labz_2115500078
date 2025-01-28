using System;

class BMICalculatore
{
    public static double CalculateBMI(double weight, double heightCm)
    {
        double heightM = heightCm / 100;  // Convert cm to meters
        return weight / (heightM * heightM);
    }

    public static string GetBMIStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        else if (bmi < 24.9) return "Normal Weight";
        else if (bmi < 29.9) return "Overweight";
        else return "Obese";
    }

    static void Main()
    {
        double[,] data = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight (kg) for person {i + 1}: ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.Write($"Enter height (cm) for person {i + 1}: ");
            data[i, 1] = double.Parse(Console.ReadLine());

            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
        }

        Console.WriteLine("\nPerson\tWeight (kg)\tHeight (cm)\tBMI\tStatus");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}\t{data[i, 0]}\t\t{data[i, 1]}\t\t{data[i, 2]:F2}\t{GetBMIStatus(data[i, 2])}");
        }
    }
}
