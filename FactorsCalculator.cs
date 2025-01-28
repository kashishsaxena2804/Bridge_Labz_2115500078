using System;
using System.Linq;

class FactorsCalculator
{
    public static int[] GetFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
            if (number % i == 0) count++;

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
            if (number % i == 0) factors[index++] = i;

        return factors;
    }

    public static int GetSum(int[] factors) => factors.Sum();
    public static int GetProduct(int[] factors) => factors.Aggregate(1, (a, b) => a * b);
    public static double GetSumOfSquares(int[] factors) => factors.Sum(f => Math.Pow(f, 2));

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = GetFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine("Sum of Factors: " + GetSum(factors));
        Console.WriteLine("Product of Factors: " + GetProduct(factors));
        Console.WriteLine("Sum of Squares of Factors: " + GetSumOfSquares(factors));
    }
}
