using System;

class FriendsComparison
{
    public static void Main()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];

        string[] names = { "Amar", "Akbar", "Anthony" };

        // Input ages and heights
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter age of {names[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter height of {names[i]} (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Find youngest and tallest
        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;

            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }

        Console.WriteLine($"\nThe youngest friend is {names[youngestIndex]} (Age: {ages[youngestIndex]})");
        Console.WriteLine($"The tallest friend is {names[tallestIndex]} (Height: {heights[tallestIndex]} cm)");
    }
}
