using System;

class TimeZoneDisplay
{
    static void Main()
    {
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, ist);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pst);

        Console.WriteLine($"UTC Time: {utcNow}");
        Console.WriteLine($"IST Time: {istTime}");
        Console.WriteLine($"PST Time: {pstTime}");
    }
}
