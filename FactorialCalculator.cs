using System;

class FactorialCalculator
{
    static long Factorial(int num)
    {
        if (num == 0 || num == 1) return 1;
        return num * Factorial(num - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factorial of {number} is: {Factorial(number)}");
    }
}
