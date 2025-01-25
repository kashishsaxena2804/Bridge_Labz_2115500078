using System;

class StudentGradeCalculator2DArray
{
    public static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // 2D array to store marks for Physics, Chemistry, and Maths
        int[,] marks = new int[numberOfStudents, 3];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];

        // Input marks for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            for (int j = 0; j < 3; j++)
            {
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                marks[i, j] = GetValidMarks(subject);
            }
        }

        // Calculate percentages and grades
        for (int i = 0; i < numberOfStudents; i++)
        {
            int totalMarks = 0;

            for (int j = 0; j < 3; j++)
            {
                totalMarks += marks[i, j];
            }

            percentages[i] = totalMarks / 3.0;
            grades[i] = AssignGrade(percentages[i]);
        }

        // Display the results
        Console.WriteLine("\nStudent Results:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"{i + 1}\t");

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{marks[i, j]}\t");
            }

            Console.WriteLine($"{percentages[i]:F2}\t\t{grades[i]}");
        }
    }

    static int GetValidMarks(string subject)
    {
        int marks;
        do
        {
            Console.Write($"Enter marks for {subject} (0-100): ");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks! Please enter a value between 0 and 100.");
            }
        } while (marks < 0 || marks > 100);

        return marks;
    }

    static string AssignGrade(double percentage)
    {
        if (percentage >= 90) return "A";
        else if (percentage >= 75) return "B";
        else if (percentage >= 50) return "C";
        else return "F";
    }
}
