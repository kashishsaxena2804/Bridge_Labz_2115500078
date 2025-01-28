using System;

class ChocolateDivider
{
    public static int[] FindRemainderAndQuotient(int chocolates, int children)
    {
        return new int[] { chocolates / children, chocolates % children };
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(chocolates, children);
        Console.WriteLine($"Each child gets {result[0]} chocolates. Remaining chocolates: {result[1]}.");
    }
}
