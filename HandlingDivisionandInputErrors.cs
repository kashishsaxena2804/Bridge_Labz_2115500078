using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HandlingDivisionandInputErrors

{
    public static void Main(string[] args)
    {
        //perform division operation
        try
        {
            Console.WriteLine("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int num = a / b;
            Console.WriteLine(num);
        }

        //handling division by zero
        catch (DivideByZeroException)
        {
            Console.WriteLine("Denominator cannot be zero");
        }
        //handling format exception
        catch (FormatException)
        {
            Console.WriteLine("Input valid data type");
        }

        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error has occurred " + ex.Message);
        }
    }
}

