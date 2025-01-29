using System;

class NumberGuessingGame
{
    static Random random = new Random();

    static int GenerateGuess(int low, int high)
    {
        return random.Next(low, high + 1);
    }

    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100. The computer will guess it.");
        int low = 1, high = 100, guess;
        string feedback;

        do
        {
            guess = GenerateGuess(low, high);
            Console.WriteLine($"Is your number {guess}? (Enter 'high', 'low', or 'correct')");
            feedback = Console.ReadLine().ToLower();

            if (feedback == "high")
                high = guess - 1;
            else if (feedback == "low")
                low = guess + 1;

        } while (feedback != "correct");

        Console.WriteLine($"The computer guessed your number: {guess}!");
    }
}
