using System;

class BMICalculator {
    static void Main(string[] args) {
        Console.WriteLine("Enter your weight in kg:");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your height in cm:");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);

        Console.WriteLine($"Your BMI is: {bmi:F2}");
        if (bmi < 18.5) {
            Console.WriteLine("Underweight");
        } else if (bmi < 25) {
            Console.WriteLine("Normal weight");
        } else if (bmi < 30) {
            Console.WriteLine("Overweight");
        } else {
            Console.WriteLine("Obesity");
        }
    }
}
