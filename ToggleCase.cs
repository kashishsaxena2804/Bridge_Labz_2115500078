using System;
using System.Text;

class ToggleCaseCharacters
{
    static string ToggleCase(string input)
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsUpper(c))
                result.Append(char.ToLower(c));
            else if (char.IsLower(c))
                result.Append(char.ToUpper(c));
            else
                result.Append(c);
        }
        return result.ToString();
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Toggled Case: " + ToggleCase(input));
    }
}
