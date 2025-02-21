using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class UsingNestedtrycatchBlocks
{
    static void Main()
    {
        try
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.Write("Enter the index to access: ");
            int index = int.Parse(Console.ReadLine());

            try
            {
                int value = numbers[index]; // May throw IndexOutOfRangeException
                Console.Write("Enter the divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                try
                {
                    int result = value / divisor; // May throw DivideByZeroException
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}

