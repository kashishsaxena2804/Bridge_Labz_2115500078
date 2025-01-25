using System;

class LargestDigitsFinder
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] digits = new int[10]; // Initialize array with size 10
        int index = 0;

        // Extract digits and store in the array
        while (number > 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = -1, secondLargest = -1;

        // Find largest and second-largest
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"Largest Digit: {largest}");
        Console.WriteLine($"Second Largest Digit: {secondLargest}");
    }
}
