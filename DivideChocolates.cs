using System;

class DivideChocolates
{
    public static void Main(string[] args)
    {
        // Input: Get number of chocolates and children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate chocolates per child and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Output the results
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild}, and the number of remaining chocolates is {remainingChocolates}.");
    }
}
