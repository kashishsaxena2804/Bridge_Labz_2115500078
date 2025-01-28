using System;

class DivisionCalculator
{
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number / divisor, number % divisor };
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine($"Quotient: {result[0]}, Remainder: {result[1]}");
    }
}
