using System;

class DiscountedFeeCalculator
{
    public static void Main(string[] args)
    {
        // Create variables for fee and discount percentage
        double fee, discountPercent;

        // Ask the user for the fee and discount percentage
        Console.Write("Enter the course fee (INR): ");
        fee = double.Parse(Console.ReadLine());  // User input for course fee

        Console.Write("Enter the discount percentage: ");
        discountPercent = double.Parse(Console.ReadLine());  // User input for discount percentage

        // Calculate the discount
        double discount = (fee * discountPercent) / 100;

        // Calculate the final fee after applying the discount
        double finalFee = fee - discount;

        // Output the discount amount and final discounted fee
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }
}
