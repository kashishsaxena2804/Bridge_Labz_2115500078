using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
    }
}
