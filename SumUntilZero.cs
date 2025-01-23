using System;

class SumUntilZero {
    public static void Main(string[] args) {
        // Variable to store the total sum
        double total = 0.0;

        Console.WriteLine("Enter numbers to sum (enter 0 to stop):");

        while (true) {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Exit the loop if the user enters 0
            if (userInput == 0) {
                break;
            }

            // Add the input value to the total
            total += userInput;
        }

        // Display the total sum
        Console.WriteLine($"The total sum is: {total}");
    }
}
