using System;

class NumberClassification
{
    public static bool IsPositive(int num) => num >= 0;
    public static bool IsEven(int num) => num % 2 == 0;
    public static int CompareNumbers(int num1, int num2) => num1 > num2 ? 1 : num1 < num2 ? -1 : 0;

    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{numbers[i]} is {(IsPositive(numbers[i]) ? "Positive" : "Negative")} and {(IsEven(numbers[i]) ? "Even" : "Odd")}");
        }

        int result = CompareNumbers(numbers[0], numbers[4]);
        Console.WriteLine($"First and Last Element Comparison: {(result == 0 ? "Equal" : result > 0 ? "First is Greater" : "Last is Greater")}");
    }
}
