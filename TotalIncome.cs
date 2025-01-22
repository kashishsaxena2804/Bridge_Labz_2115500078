using System;

class TotalIncome
{
    public static void Main(string[] args)
    {
        // Input: Prompt the user to enter salary and bonus
        Console.Write("Enter your salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculate total income
        double totalIncome = salary + bonus;

        // Output the result
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}.");
    }
}
