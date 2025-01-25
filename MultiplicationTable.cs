using System;

class MultiplicationTable
{
    public static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = int.Parse(Console.ReadLine());
        int[] table = new int[10];

        for (int i = 0; i < 10; i++)
        {
            table[i] = number * (i + 1);
            Console.WriteLine($"{number} x {i + 1} = {table[i]}");
        }
    }
}
