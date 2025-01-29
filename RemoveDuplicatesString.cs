using System;
using System.Text;

class RemoveDuplicatesString
{
    static string RemoveDuplicates(string input)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in input)
        {
            if (!result.ToString().Contains(c))
                result.Append(c);
        }
        return result.ToString();
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("String without duplicates: " + RemoveDuplicates(input));
    }
}
