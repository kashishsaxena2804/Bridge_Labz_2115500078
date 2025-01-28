using System;

class TrigonometryCalculator
{
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = Math.PI * angle / 180.0;
        return new double[] { Math.Sin(radians), Math.Cos(radians), Math.Tan(radians) };
    }

    static void Main(string[] args)
    {
        Console.Write("Enter angle (degrees): ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] trigValues = CalculateTrigonometricFunctions(angle);
        Console.WriteLine($"Sin({angle}) = {trigValues[0]:F4}, Cos({angle}) = {trigValues[1]:F4}, Tan({angle}) = {trigValues[2]:F4}");
    }
}
