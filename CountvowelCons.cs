using System;

class CountVowelsCons
{
    static void CountVowelsConsonants(string input, out int vowels, out int consonants)
    {
        vowels = 0;
        consonants = 0;
        string vowelsList = "aeiouAEIOU";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (vowelsList.Contains(c))
                    vowels++;
                else
                    consonants++;
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        CountVowelsConsonants(input, out int vowels, out int consonants);

        Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
    }
}
