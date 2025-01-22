using System;

class AverageMarks {
    public static void Main(string[] args) {
        
        // Marks obtained in each subject
        int maths = 94;
        int physics = 95;
        int chemistry = 96;

        // Calculate total marks and average
        int totalMarks = (maths + physics + chemistry);
        double averageMarks = totalMarks / 3.0; // Divide by 3.0 to get decimal result

        // Print the average percentage
        Console.WriteLine("Sam's average mark in PCM is " + averageMarks + "%");
    }
}
