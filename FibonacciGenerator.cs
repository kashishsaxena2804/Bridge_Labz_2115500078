using System;

class FibonacciGenerator
{
    static void GenerateFibonacci(int terms)
    {
        int a = 0, b = 1, next;
        Console.Write("Fibonacci Sequence: ");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(a + " ");
            next = a + b;
            a = b;
            b = next;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        GenerateFibonacci(terms);
    }
}
