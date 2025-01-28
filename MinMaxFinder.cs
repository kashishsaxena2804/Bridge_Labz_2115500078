using System;

class MinMaxFinder
{
    public static int[] FindSmallestAndLargest(int num1, int num2, int num3)
    {
        int smallest = Math.Min(num1, Math.Min(num2, num3));
        int largest = Math.Max(num1, Math.Max(num2, num3));
        return new int[] { smallest, largest };
    }

    static void Main(string[] args)
    {
        Console.Write("Enter three numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int[] result = FindSmallestAndLargest(num1, num2, num3);
        Console.WriteLine($"Smallest: {result[0]}, Largest: {result[1]}");
    }
}
