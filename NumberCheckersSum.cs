using System;
using System.Linq;

class NumberCheckerSum
{
    static void Main()
    {
        int number = 18;
        int[] digits = GetDigits(number);
        Console.WriteLine($"Sum of Digits: {digits.Sum()}");
        Console.WriteLine($"Sum of Squares: {digits.Sum(d => d * d)}");
        Console.WriteLine($"Harshad Number: {number % digits.Sum() == 0}");
        int[,] freq = FindDigitFrequency(digits);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++) if (freq[i, 1] > 0) Console.WriteLine($"{freq[i, 0]}: {freq[i, 1]}");
    }

    static int[] GetDigits(int num) => num.ToString().Select(d => d - '0').ToArray();
    static int[,] FindDigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++) freq[i, 0] = i;
        foreach (int d in digits) freq[d, 1]++;
        return freq;
    }
}
