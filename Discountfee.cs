using System;

class DiscountFee
{
    public static void Main(string[] args)
    {
        // Initial values
        double fee = 125000;
        double discountPercent = 10;

        // Compute the discount amount
        double discount = (fee * discountPercent) / 100;

        // Compute the final discounted fee
        double finalFee = fee - discount;

        // Print the result
        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
    }
}
