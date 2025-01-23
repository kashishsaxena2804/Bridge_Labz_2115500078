using System;

class PowerCalculator {
    static void Main(string[] args) {
        Console.Write("Enter the base number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= power; i++) {
            result *= number;
        }

        Console.WriteLine($"{number} raised to the power {power} is: {result}");
    }
}
