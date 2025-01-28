using System;
using System.Linq;

class NumberCheckerPalindrome
{
    static void Main()
    {
        int number = 121;
        int[] digits = GetDigits(number);
        int[] reversed = digits.Reverse().ToArray();
        Console.WriteLine($"Palindrome: {digits.SequenceEqual(reversed)}");
        Console.WriteLine($"Duck Number: {digits.Contains(0)}");
    }

    static int[] GetDigits(int num) => num.ToString().Select(d => d - '0').ToArray();
}
