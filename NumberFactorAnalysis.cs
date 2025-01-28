using System;
using System.Linq;

class NumberFactorAnalysis
{
    static void Main()
    {
        int num = 28;
        int[] factors = FindFactors(num);
        Console.WriteLine($"Perfect: {IsPerfect(factors, num)}");
        Console.WriteLine($"Abundant: {IsAbundant(factors, num)}");
        Console.WriteLine($"Deficient: {IsDeficient(factors, num)}");
    }

    static int[] FindFactors(int num) => Enumerable.Range(1, num).Where(i => num % i == 0).ToArray();
    static bool IsPerfect(int[] factors, int num) => factors.Sum() - num == num;
    static bool IsAbundant(int[] factors, int num) => factors.Sum() - num > num;
    static bool IsDeficient(int[] factors, int num) => factors.Sum() - num < num;
}
