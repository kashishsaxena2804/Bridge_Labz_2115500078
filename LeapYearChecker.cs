using System;

class LeapYearChecker {
    static void Main(string[] args) {
        Console.Write("Enter a year (>= 1582): ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582) {
            Console.WriteLine("The year must be 1582 or later.");
        } else {
            if (year % 4 == 0) {
                if (year % 100 == 0) {
                    if (year % 400 == 0) {
                        Console.WriteLine($"{year} is a Leap Year.");
                    } else {
                        Console.WriteLine($"{year} is not a Leap Year.");
                    }
                } else {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
            } else {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
    }
}
