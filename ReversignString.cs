using System;

class Program
{
    static string ReverseString(string input)
    {
        char[] reversed = new char[input.Length];
        int j = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed[j++] = input[i];
        }

        return new string(reversed);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Reversed String: " + ReverseString(input));
    }
}

