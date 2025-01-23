using System;

class PrimeNumberChecker {
    static void Main(string[] args) {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 1) {
            Console.WriteLine($"{number} is not a prime number.");
        } else {
            bool isPrime = true;

            for (int i = 2; i * i <= number; i++) {
                if (number % i == 0) {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? $"{number} is a prime number." : $"{number} is not a prime number.");
        }
    }
}
 