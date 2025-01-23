using System;

class RocketLaunchCountdownfor {
    public static void Main(string[] args) {
        // Prompt the user to enter the countdown starting number
        Console.Write("Enter the starting countdown number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nStarting countdown:");
        // Use a for loop to count down to 1
        for (int i = counter; i >= 1; i--) {
            Console.WriteLine(i); // Print the current countdown number
        }

        // Print the rocket launch message
        Console.WriteLine("Rocket Launched!");
    }
}
