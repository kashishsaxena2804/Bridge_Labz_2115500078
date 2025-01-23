using System;

class MultiplesBelow100 {
    static void Main(string[] args) {
        Console.Write("Enter a number to find its multiples below 100: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiples of {number} below 100:");
        for (int i = 100; i >= 1; i--) {
            if (i % number == 0) {
                Console.WriteLine(i);
            }
        }
    }
}
