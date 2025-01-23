using System;

class Calculator
{
    static void Main(string[] args)
    {
        // Prompt the user for inputs
        Console.WriteLine("Enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the operator (+, -, *, /):");
        string op = Console.ReadLine();

        // Perform the operation based on the operator
        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine($"Result: {first / second}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
