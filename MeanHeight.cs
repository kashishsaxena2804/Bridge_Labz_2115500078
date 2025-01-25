using System;

class MeanHeight
{
    public static void Main()
    {
        double[] heights = new double[11];
        double total = 0.0;

        for (int i = 0; i < 11; i++)
        {
            Console.Write($"Enter height of player {i + 1}: ");
            heights[i] = double.Parse(Console.ReadLine());
            total += heights[i];
        }

        double mean = total / 11;
        Console.WriteLine($"The mean height of the football team is: {mean}");
    }
}
