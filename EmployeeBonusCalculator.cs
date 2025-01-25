using System;

class EmployeeBonusCalculator
{
    public static void Main()
    {
        double[] salaries = new double[10];
        int[] yearsOfService = new int[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        // Input salary and years of service
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter salary for employee {i + 1}: ");
            salaries[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter years of service for employee {i + 1}: ");
            yearsOfService[i] = Convert.ToInt32(Console.ReadLine());

            // Validate inputs
            if (salaries[i] < 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter positive values.");
                i--; // Retry for invalid input
                continue;
            }
        }

        // Calculate bonuses and new salaries
        for (int i = 0; i < 10; i++)
        {
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        // Display results
        Console.WriteLine("\nEmployee Details:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Employee {i + 1}: Old Salary = {salaries[i]}, Bonus = {bonuses[i]}, New Salary = {newSalaries[i]}");
        }
        Console.WriteLine($"\nTotal Bonus: {totalBonus}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
    }
}
