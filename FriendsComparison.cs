using System;

class FriendsComparison {
    static void Main(string[] args) {
        Console.WriteLine("Enter age and height for Amar:");
        int ageAmar = Convert.ToInt32(Console.ReadLine());
        double heightAmar = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter age and height for Akbar:");
        int ageAkbar = Convert.ToInt32(Console.ReadLine());
        double heightAkbar = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter age and height for Anthony:");
        int ageAnthony = Convert.ToInt32(Console.ReadLine());
        double heightAnthony = Convert.ToDouble(Console.ReadLine());

        int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        double tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));

        Console.WriteLine($"Youngest age is: {youngestAge}");
        Console.WriteLine($"Tallest height is: {tallestHeight} cm");
    }
}
