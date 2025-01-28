using System;

class QuadraticEquationSolver
{
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = (b * b) - (4 * a * c);
        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else return new double[0];  // No real roots
    }

    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0)
            Console.WriteLine("No real roots.");
        else
            Console.WriteLine("Roots: " + string.Join(", ", roots));
    }
}
