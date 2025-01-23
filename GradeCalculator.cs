using System;

class GradeCalculator {
    static void Main(string[] args) {
        // Input marks for Physics, Chemistry, and Mathematics
        Console.Write("Enter marks for Physics: ");
        double physics = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        double chemistry = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Mathematics: ");
        double maths = Convert.ToDouble(Console.ReadLine());

        // Compute total marks and percentage
        double totalMarks = physics + chemistry + maths;
        double percentage = (totalMarks / 300) * 100; // Assuming each subject has 100 marks

        // Determine grade and remarks
        string grade;
        string remarks;

        if (percentage >= 80) {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        } else if (percentage >= 70) {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        } else if (percentage >= 60) {
            grade = "C";
            remarks = "Level 2, below, but approaching agency-normalized standards";
        } else if (percentage >= 50) {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        } else if (percentage >= 40) {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";
        } else {
            grade = "R";
            remarks = "Remedial standards";
        }

        // Display results
        Console.WriteLine("\n----- Result -----");
        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }
}
