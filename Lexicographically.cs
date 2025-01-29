using System;

class Lexicographically
{
    static int CompareStrings(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] != str2[i])
                return str1[i] - str2[i];
        }
        return str1.Length - str2.Length;
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = CompareStrings(str1, str2);

        Console.WriteLine(result < 0 ? $"{str1} comes before {str2}" :
                          result > 0 ? $"{str2} comes before {str1}" :
                          "Both strings are equal");
    }
}
