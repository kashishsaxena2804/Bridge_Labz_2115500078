using System;

class MatrixOperations
{
    static void Main()
    {
        int[,] matrixA = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrixB = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        Console.WriteLine("Matrix Addition:");
        PrintMatrix(MatrixAddition(matrixA, matrixB));

        Console.WriteLine("Matrix Subtraction:");
        PrintMatrix(MatrixSubtraction(matrixA, matrixB));

        Console.WriteLine("Matrix Multiplication:");
        PrintMatrix(MatrixMultiplication(matrixA, matrixB));

        Console.WriteLine("Matrix Transpose:");
        PrintMatrix(MatrixTranspose(matrixA));
    }

    static int[,] MatrixAddition(int[,] A, int[,] B)
    {
        int[,] result = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                result[i, j] = A[i, j] + B[i, j];
        return result;
    }

    static int[,] MatrixSubtraction(int[,] A, int[,] B)
    {
        int[,] result = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                result[i, j] = A[i, j] - B[i, j];
        return result;
    }

    static int[,] MatrixMultiplication(int[,] A, int[,] B)
    {
        int size = A.GetLength(0);
        int[,] result = new int[size, size];

        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                for (int k = 0; k < size; k++)
                    result[i, j] += A[i, k] * B[k, j];

        return result;
    }

    static int[,] MatrixTranspose(int[,] A)
    {
        int size = A.GetLength(0);
        int[,] result = new int[size, size];

        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                result[j, i] = A[i, j];

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        foreach (int i in matrix)
            Console.Write($"{i} ");
        Console.WriteLine();
    }
}
