using System;

class AthleteRun
{
    static int CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        return (int)Math.Ceiling(5000 / perimeter);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter side 1 (meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 (meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 (meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        int rounds = CalculateRounds(side1, side2, side3);
        Console.WriteLine($"The athlete must complete {rounds} rounds to cover 5 km.");
    }
}
