using System;

class DynamicDigitsFinder
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10; // Initial size of the array
        int[] digits = new int[maxDigit];
        int index = 0;

        // Extract digits and dynamically resize the array if needed
        while (number > 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length);
                digits = temp;
            }

            digits[index++] = number % 10;
            number /= 10;
        }

        // Find the largest and second largest digits
        int largest = -1, secondLargest = -1;

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

        // Display results
        Console.WriteLine($"Largest Digit: {largest}");
        Console.WriteLine($"Second Largest Digit: {secondLargest}");
    }
}
