using System;

class PurchaseCalculator
{
    // Method to calculate and display the total price
    public void CalculateTotalPrice()
    {
        // Input unit price and quantity
        Console.Write("Enter the unit price of the item (INR): ");
        decimal unitPrice = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price
        decimal totalPrice = unitPrice * quantity;

        // Output the result
        Console.WriteLine($"The total purchase price is INR {totalPrice:F2} if the quantity is {quantity} and unit price is INR {unitPrice:F2}.");
    }
	public static void Main(string[] args)
    {
        // Create an instance of the class
        PurchaseCalculator calculator = new PurchaseCalculator();

        // Call the method
        calculator.CalculateTotalPrice();
    }

}

