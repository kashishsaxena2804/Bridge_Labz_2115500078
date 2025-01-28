using System;

class LeapYearChecker
{
    public static bool IsLeapYear(int year)
    {
        return year >= 1582 && (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
    }

    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine(IsLeapYear(year) ? "Leap Year" : "Not a Leap Year");
    }
}
