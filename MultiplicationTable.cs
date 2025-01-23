using System;

class MultiplicationTable {
    public static void Main(string[] args) {
        // Prompt the user for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Generate multiplication table for the number from 6 to 9
        for (int i = 6; i <= 9; i++) {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
