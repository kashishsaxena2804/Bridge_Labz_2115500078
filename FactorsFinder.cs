using System;

class FactorsFinder {
    static void Main(string[] args) {
        Console.Write("Enter a number to find its factors: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The factors of {number} are:");
        for (int i = 1; i <= number; i++) {
            if (number % i == 0) {
                Console.WriteLine(i);
            }
        }
    }
}
