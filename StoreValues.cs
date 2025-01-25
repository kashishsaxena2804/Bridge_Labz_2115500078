using System;

class StoreValues
{
    public static void Main()
    {
        double[] values = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write($"Enter a number (0 or negative to stop): ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == 10)
                break;

            values[index] = input;
            index++;
        }

        for (int i = 0; i < index; i++)
        {
            total += values[i];
            Console.WriteLine($"Value {i + 1}: {values[i]}");
        }

        Console.WriteLine($"Total of entered numbers: {total}");
    }
}
