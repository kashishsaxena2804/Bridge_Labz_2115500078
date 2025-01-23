using System;

class EmployeeBonus {
    public static void Main(string[] args) {
        // Prompt the user for their salary
        Console.Write("Enter your salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for their years of service
        Console.Write("Enter your years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        // Check if the employee is eligible for the bonus
        if (yearsOfService > 5) {
            // Calculate the bonus (5% of salary)
            double bonus = 0.05 * salary;
            Console.WriteLine($"You are eligible for a bonus of: {bonus:F2}");
        } else {
            Console.WriteLine("You are not eligible for a bonus.");
        }
    }
}
