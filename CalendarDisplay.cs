using System;
using System.Globalization;

class CalendarDisplay
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        DisplayCalendar(year, month);
    }

    static void DisplayCalendar(int year, int month)
    {
        Console.WriteLine($"\n{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int startDay = (int)new DateTime(year, month, 1).DayOfWeek;
        int daysInMonth = DateTime.DaysInMonth(year, month);

        for (int i = 0; i < startDay; i++) Console.Write("    ");
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3} ");
            if ((day + startDay) % 7 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }
}
