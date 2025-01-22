using System;

class HandshakeCalculator
{
    // Method to calculate the maximum number of handshakes
    public int CalculateMaxHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }
	
	/*static void Main()
    {
        // Input the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Create an instance of HandshakeCalculator
        HandshakeCalculator calculator = new HandshakeCalculator();

        // Call the method to calculate the maximum handshakes
        int maxHandshakes = calculator.CalculateMaxHandshakes(numberOfStudents);

        // Display the result
        Console.WriteLine($"The maximum number of possible handshakes among {numberOfStudents} students is {maxHandshakes}.");
    }*/
}
