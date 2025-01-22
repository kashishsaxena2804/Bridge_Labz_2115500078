using System;

class SimpleInterest
{
    public static void Main(string[] args)
    {
        // Input: Prompt user to enter principal, rate, and time
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate simple interest
        double simpleInterest = (principal * rate * time) / 100;

        // Output the result
        Console.WriteLine($"The Simple Interest is {simpleInterest:F2} for Principal {principal}, Rate of Interest {rate}%, and Time {time} years.");
    }
}
