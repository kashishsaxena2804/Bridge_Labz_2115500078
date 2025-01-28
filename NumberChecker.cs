using System;

class NumberChecker
{
    static int CheckNumber(int number)
    {
        if (number > 0) return 1;
        if (number < 0) return -1;
        return 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = CheckNumber(number);
        string status = result == 1 ? "Positive" : result == -1 ? "Negative" : "Zero";

        Console.WriteLine($"The number {number} is {status}.");
    }
}
