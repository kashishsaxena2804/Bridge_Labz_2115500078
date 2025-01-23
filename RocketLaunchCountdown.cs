using System;

class RocketLaunchCountdown {
    public static void Main(string[] args) {
        // Prompt the user to enter the countdown starting number
        Console.Write("Enter the starting countdown number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nStarting countdown:");
        // Use a while loop to count down to 1
        while (counter >= 1) {
            Console.WriteLine(counter); // Print the current countdown number
            counter--; // Decrement the counter
        }

        // Print the rocket launch message
        Console.WriteLine("Rocket Launched!");
    }
}
