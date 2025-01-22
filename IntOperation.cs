using System;

// Class to perform integer operations
class IntOperation
{
    // Method to calculate and display the results of integer operations
    public void PerformOperations(int a, int b, int c)
    {
        // Compute the integer operations
        int result1 = a + b * c;      // Multiplication has higher precedence than addition
        int result2 = a * b + c;      // Multiplication first, then addition
        int result3 = c + a / b;      // Division has higher precedence than addition
        int result4 = a % b + c;      // Modulus first, then addition

        // Display the results
        Console.WriteLine($"The results of Int Operations are:");
        Console.WriteLine($"a + b * c = {result1}");
        Console.WriteLine($"a * b + c = {result2}");
        Console.WriteLine($"c + a / b = {result3}");
        Console.WriteLine($"a % b + c = {result4}");

        // Explain operator precedence
        Console.WriteLine("\nOperator Precedence:");
        Console.WriteLine("1. Parentheses ( )");
        Console.WriteLine("2. Multiplication *, Division /, Modulus %");
        Console.WriteLine("3. Addition +, Subtraction -");
    }
	public static void Main(string[] args)
    {
        // Input: Prompt the user to enter the values of a, b, and c
        Console.Write("Enter the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Create an instance of IntOperation
        IntOperation operation = new IntOperation();

        // Call the method to perform operations and display results
        operation.PerformOperations(a, b, c);
    }
}


