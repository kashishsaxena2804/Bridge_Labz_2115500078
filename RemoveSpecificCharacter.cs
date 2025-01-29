using System;

class RemoveSpecificCharacter
{
    static string RemoveCharacter(string input, char removeChar)
    {
        return input.Replace(removeChar.ToString(), "");
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char removeChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Modified String: " + RemoveCharacter(input, removeChar));
    }
}
