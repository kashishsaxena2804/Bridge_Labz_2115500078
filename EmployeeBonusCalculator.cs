using System;

class EmployeeBonusCalculator
{
    static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Joining Year: ");
        int joiningYear = int.Parse(Console.ReadLine());

        Console.WriteLine($"{name} Bonus: ${CalculateBonus(joiningYear):F2}");
    }

    static double CalculateBonus(int joiningYear)
    {
        int currentYear = DateTime.Now.Year;
        int experience = currentYear - joiningYear;

        if (experience >= 10) return 10000;
        else if (experience >= 5) return 5000;
        else return 2000;
    }
}
