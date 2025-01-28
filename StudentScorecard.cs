using System;

class StudentScorecard
{
    static void Main()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Physics Marks: ");
        double physics = double.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry Marks: ");
        double chemistry = double.Parse(Console.ReadLine());

        Console.Write("Enter Math Marks: ");
        double math = double.Parse(Console.ReadLine());

        double total = physics + chemistry + math;
        double average = total / 3;
        double percentage = (total / 300) * 100;

        Console.WriteLine($"{name}'s Scorecard:");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
    }
}
