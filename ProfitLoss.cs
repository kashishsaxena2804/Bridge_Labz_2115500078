using System;

class ProfitLoss {
    public static void Main(string[] args) {
        // Cost price and Selling price
        int costprice = 129;
        int sellingprice = 191;

        // Calculate the Profit
        int profit = sellingprice - costprice;

        // Calculate the Profit Percentage
        double percentage = (profit * 100.0) / costprice;

        // Print the result
        Console.WriteLine("The Cost Price is INR " + costprice + " and Selling Price is INR " + sellingprice);
        Console.WriteLine("The Profit is INR " + profit + " and the Profit Percentage is " + percentage + " %");
    }
}
