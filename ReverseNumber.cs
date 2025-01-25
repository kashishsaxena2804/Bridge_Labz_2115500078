using System;

class ReverseNumber
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] digits = new int[10];
        int index = 0;

        // Extract digits into array
        while (number > 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        Console.WriteLine("Reversed Number: ");
        for (int i = index - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}
