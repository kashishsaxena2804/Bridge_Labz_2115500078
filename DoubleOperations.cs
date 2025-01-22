using System;

// Class to perform double operations
class DoubleOpt
{
    // Method to perform operations and display results
    public void PerformOperations(double a, double b, double c)
    {
        // Perform the operations
        double result1 = a + b * c;      // Multiplication has higher precedence than addition
        double result2 = a * b + c;      // Multiplication first, then addition
        double result3 = c + a / b;      // Division has higher precedence than addition
        double result4 = a % b + c;      // Modulus first, then addition

        // Display the results
        Console.WriteLine($"The results of Double Operations are:");
        Console.WriteLine($"a + b * c = {result1:F2}");
        Console.WriteLine($"a * b + c = {result2:F2}");
        Console.WriteLine($"c + a / b = {result3:F2}");
        Console.WriteLine($"a % b + c = {result4:F2}");
    }
	
	static void Main()
    {
        // Input: Prompt the user to enter the values of a, b, and c
        Console.Write("Enter the value of a (double): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of b (double): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of c (double): ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Create an instance of DoubleOpt
        DoubleOpt operation = new DoubleOpt();

        // Call the method to perform operations and display results
        operation.PerformOperations(a, b, c);
    }
}

