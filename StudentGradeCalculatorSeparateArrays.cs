using System;

class StudentGradeCalculatorSeparateArrays
{
    public static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int[] physics = new int[numberOfStudents];
        int[] chemistry = new int[numberOfStudents];
        int[] maths = new int[numberOfStudents];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];

        // Input marks for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            physics[i] = GetValidMarks("Physics");
            chemistry[i] = GetValidMarks("Chemistry");
            maths[i] = GetValidMarks("Maths");
        }

        // Calculate percentages and grades
        for (int i = 0; i < numberOfStudents; i++)
        {
            int totalMarks = physics[i] + chemistry[i] + maths[i];
            percentages[i] = totalMarks / 3.0;

            grades[i] = AssignGrade(percentages[i]);
        }

        // Display the results
        Console.WriteLine("\nStudent Results:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{physics[i]}\t{chemistry[i]}\t\t{maths[i]}\t{percentages[i]:F2}\t\t{grades[i]}");
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
