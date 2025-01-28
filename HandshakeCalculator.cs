using System;

class HandshakeCalculators
{
    static int CalculateHandshakes(int students)
    {
        return (students * (students - 1)) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());

        int handshakes = CalculateHandshakes(students);
        Console.WriteLine($"The maximum number of handshakes among {students} students is {handshakes}.");
    }
}
