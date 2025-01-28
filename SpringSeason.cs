using System;

class SpringSeasons
{
    static bool IsSpringSeason(int month, int day)
    {
        return (month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter Day: ");
        int day = int.Parse(Console.ReadLine());

        if (IsSpringSeason(month, day))
            Console.WriteLine("It's Spring Season!");
        else
            Console.WriteLine("Not a Spring Season.");
    }
}
