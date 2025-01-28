using System;

class NaturalSum
{
    static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = CalculateSum(number);
        Console.WriteLine($"The sum of first {number} natural numbers is {sum}.");
    }
}
