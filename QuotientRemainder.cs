using System;

// A class that handles calculations for division
class QuotientRemainder
{
    // This method calculates and prints the quotient and remainder
    public void CalculateQuotientAndRemainder(int number1, int number2)
    {
        // Check if the second number is zero to avoid division by zero
        if (number2 == 0)
        {
            Console.WriteLine("Oops! Division by zero is not allowed. Please try again with a valid number.");
            return;
        }

        // Calculate the quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Print the results in a human-friendly format
        Console.WriteLine($"The Quotient is {quotient} and the Remainder is {remainder} for the numbers {number1} and {number2}.");
    }
	public static void Main(string[] args)
    {
        // Ask the user to enter the first number
        Console.Write("Please enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to enter the second number
        Console.Write("Please enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the DivisionCalculator class
        QuotientRemainder calculator = new QuotientRemainder();

        // Use the instance to calculate and display the quotient and remainder
        calculator.CalculateQuotientAndRemainder(number1, number2);
    }
}

