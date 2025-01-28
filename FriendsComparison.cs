using System;

class FriendsComparison
{
    public static int FindYoungest(int[] ages) => Math.Min(Math.Min(ages[0], ages[1]), ages[2]);
    public static double FindTallest(double[] heights) => Math.Max(Math.Max(heights[0], heights[1]), heights[2]);

    static void Main()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {names[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write($"Enter height of {names[i]} (in cm): ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Youngest Friend is: {FindYoungest(ages)} years old");
        Console.WriteLine($"Tallest Friend is: {FindTallest(heights)} cm");
    }
}
