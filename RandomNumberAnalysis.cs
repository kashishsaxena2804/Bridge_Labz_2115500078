using System;

class RandomNumberAnalysis
{
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
            numbers[i] = rand.Next(1000, 9999);  // 4-digit numbers

        return numbers;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        double avg = numbers.Average();
        int min = numbers[0], max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return new double[] { avg, min, max };
    }

    static void Main()
    {
        int[] numbers = Generate4DigitRandomArray(5);

        Console.WriteLine("Generated Numbers: " + string.Join(", ", numbers));

        double[] results = FindAverageMinMax(numbers);
        Console.WriteLine($"Average: {results[0]:F2}");
        Console.WriteLine($"Min: {results[1]}");
        Console.WriteLine($"Max: {results[2]}");
    }
}
