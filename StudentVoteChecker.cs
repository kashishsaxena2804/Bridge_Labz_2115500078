using System;

class StudentVoteChecker
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0) return false;  // Invalid age
        return age >= 18;
    }

    static void Main()
    {
        int[] ages = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter age for student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Student {i + 1} (Age: {ages[i]}) => {(CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote")}");
        }
    }
}
