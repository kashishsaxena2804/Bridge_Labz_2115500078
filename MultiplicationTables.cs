using System;

class MultiplicationTables
{
    public static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table from 6 to 9: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"Multiplication table for {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
}
