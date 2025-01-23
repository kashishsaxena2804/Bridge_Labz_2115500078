using System;

class SumNaturalNumbers {
    public static void Main(string[] args) {
        // Prompt the user for input
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a natural number (non-negative integer)
        if (n < 0) {
            Console.WriteLine("The entered number is not a natural number.");
            return;
        }

        // Compute the sum using the formula
        int formulaSum = n * (n + 1) / 2;

        // Compute the sum using a while loop
        int whileSum = 0;
        int i = 1;
        while (i <= n) {
            whileSum += i;
            i++;
        }

        // Display the results
        Console.WriteLine($"Sum using the formula: {formulaSum}");
        Console.WriteLine($"Sum using the while loop: {whileSum}");

        // Verify if both results are equal
        if (formulaSum == whileSum) {
            Console.WriteLine("Both computations match! The results are correct.");
        } else {
            Console.WriteLine("There is a discrepancy in the computations.");
        }
    }
}
