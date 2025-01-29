using System;

class PrimeNumberChecker
{
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0) return false;
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
            Console.WriteLine($"{number} is a prime number.");
        else
            Console.WriteLine($"{number} is not a prime number.");
    }
}
