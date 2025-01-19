using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter radius of the cylinder: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of the cylinder: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * radius * radius * height;
        Console.WriteLine("Volume of the cylinder: " + volume);
    }
}
