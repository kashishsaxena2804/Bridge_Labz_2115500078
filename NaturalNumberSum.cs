using System;

class NaturalNumberSum
{
    public static int SumRecursive(int n) => (n == 0) ? 0 : n + SumRecursive(n - 1);
    public static int SumFormula(int n) => n * (n + 1) / 2;

    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Invalid input. Enter a natural number.");
            return;
        }

        int sumRecursive = SumRecursive(n);
        int sumFormula = SumFormula(n);

        Console.WriteLine($"Sum using recursion: {sumRecursive}");
        Console.WriteLine($"Sum using formula: {sumFormula}");
        Console.WriteLine($"Both methods give the same result: {sumRecursive == sumFormula}");
    }
}
