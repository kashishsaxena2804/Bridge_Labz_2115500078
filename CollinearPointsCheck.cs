using System;

class CollinearPointsCheck
{
    static void Main()
    {
        Console.Write("Enter x1 y1: ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2 y2: ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter x3 y3: ");
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Collinear (Slope Method): {IsCollinearSlope(x1, y1, x2, y2, x3, y3)}");
        Console.WriteLine($"Collinear (Area Method): {IsCollinearArea(x1, y1, x2, y2, x3, y3)}");
    }

    static bool IsCollinearSlope(double x1, double y1, double x2, double y2, double x3, double y3) =>
        (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);

    static bool IsCollinearArea(double x1, double y1, double x2, double y2, double x3, double y3) =>
        0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) == 0;
}
