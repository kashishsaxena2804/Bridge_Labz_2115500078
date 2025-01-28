using System;
using System.Linq;

class NumberChecker
{
    static void Main()
    {
        int number = 153;
        Console.WriteLine($"Digit Count: {DigitCount(number)}");
        int[] digits = GetDigits(number);
        Console.WriteLine($"Duck Number: {IsDuckNumber(digits)}");
        Console.WriteLine($"Armstrong Number: {IsArmstrong(number, digits)}");
        (int largest, int secondLargest) = FindLargestTwo(digits);
        Console.WriteLine($"Largest: {largest}, Second Largest: {secondLargest}");
        (int smallest, int secondSmallest) = FindSmallestTwo(digits);
        Console.WriteLine($"Smallest: {smallest}, Second Smallest: {secondSmallest}");
    }

    static int DigitCount(int num) => num.ToString().Length;
    static int[] GetDigits(int num) => num.ToString().Select(d => d - '0').ToArray();
    static bool IsDuckNumber(int[] digits) => digits.Contains(0);
    static bool IsArmstrong(int num, int[] digits) => digits.Sum(d => Math.Pow(d, digits.Length)) == num;

    static (int, int) FindLargestTwo(int[] digits)
    {
        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int d in digits) { if (d > max1) { max2 = max1; max1 = d; } else if (d > max2) max2 = d; }
        return (max1, max2);
    }

    static (int, int) FindSmallestTwo(int[] digits)
    {
        int min1 = int.MaxValue, min2 = int.MaxValue;
        foreach (int d in digits) { if (d < min1) { min2 = min1; min1 = d; } else if (d < min2) min2 = d; }
        return (min1, min2);
    }
}
