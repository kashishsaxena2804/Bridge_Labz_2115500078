using System;

class NumberCheckerPrime
{
    static void Main()
    {
        int number = 7;
        Console.WriteLine($"Prime: {IsPrime(number)}");
        Console.WriteLine($"Neon: {IsNeon(number)}");
        Console.WriteLine($"Spy: {IsSpy(number)}");
        Console.WriteLine($"Automorphic: {IsAutomorphic(number)}");
        Console.WriteLine($"Buzz: {IsBuzz(number)}");
    }

    static bool IsPrime(int num) => num > 1 && (num == 2 || num % 2 != 0 && Enumerable.Range(3, (int)Math.Sqrt(num) - 1).All(n => num % n != 0));
    static bool IsNeon(int num) => num.ToString().Select(d => d - '0').Sum() == num;
    static bool IsSpy(int num) => num.ToString().Select(d => d - '0').Sum() == num.ToString().Select(d => d - '0').Aggregate(1, (a, b) => a * b);
    static bool IsAutomorphic(int num) => Math.Pow(num, 2).ToString().EndsWith(num.ToString());
    static bool IsBuzz(int num) => num % 7 == 0 || num.ToString().EndsWith("7");
}
