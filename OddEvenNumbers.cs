using System;

class OddEvenNumbers
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number.");
            return;
        }

        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even[evenIndex++] = i;
            else
                odd[oddIndex++] = i;
        }

        Console.WriteLine("Odd Numbers: " + string.Join(", ", odd[..oddIndex]));
        Console.WriteLine("Even Numbers: " + string.Join(", ", even[..evenIndex]));
    }
}
