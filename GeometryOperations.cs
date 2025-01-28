using System;

class GeometryOperations
{
    static void Main()
    {
        Console.Write("Enter x1 y1: ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2 y2: ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Euclidean Distance: {FindDistance(x1, y1, x2, y2):F2}");
        Console.WriteLine($"Line Equation: y = {FindSlope(x1, y1, x2, y2):F2}x + {FindIntercept(x1, y1, x2, y2):F2}");
    }

    static double FindDistance(double x1, double y1, double x2, double y2) =>
        Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    static double FindSlope(double x1, double y1, double x2, double y2) =>
        (y2 - y1) / (x2 - x1);

    static double FindIntercept(double x1, double y1, double x2, double y2) =>
        y1 - FindSlope(x1, y1, x2, y2) * x1;
}
