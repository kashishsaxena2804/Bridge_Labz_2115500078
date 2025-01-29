using System;

class ReplaceWord
{
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        return sentence.Replace(oldWord, newWord);
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        Console.WriteLine("Updated Sentence: " + ReplaceWord(sentence, oldWord, newWord));
    }
}
