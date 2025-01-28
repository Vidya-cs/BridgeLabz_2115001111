using System;

class Program13
{
    public static int[,] CreateMatrix(int rows, int cols)
    {
        Random rand = new Random();
        int[,] mat = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                mat[i, j] = rand.Next(1, 10);
            }
        }
        return mat;
    }

    public static int[,] AddMatrices(int[,] mat1, int[,] mat2)
    {
        int rows = mat1.GetLength(0), cols = mat1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = mat1[i, j] + mat2[i, j];
            }
        }
        return result;
    }

    public static int[,] SubtractMatrices(int[,] mat1, int[,] mat2)
    {
        int rows = mat1.GetLength(0), cols = mat1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = mat1[i, j] - mat2[i, j];
            }
        }
        return result;
    }

    public static int[,] MultiplyMatrices(int[,] mat1, int[,] mat2)
    {
        int rows = mat1.GetLength(0), cols = mat2.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < mat1.GetLength(1); k++)
                {
                    result[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }
        return result;
    }

    public static int[,] TransposeMatrix(int[,] mat)
    {
        int rows = mat.GetLength(0), cols = mat.GetLength(1);
        int[,] result = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = mat[i, j];
            }
        }
        return result;
    }

    public static void PrintMatrix(int[,] mat)
    {
        int rows = mat.GetLength(0), cols = mat.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        int[,] matrix1 = CreateMatrix(3, 3);
        int[,] matrix2 = CreateMatrix(3, 3);
        
        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);
        
        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2);
        
        Console.WriteLine("Addition:");
        PrintMatrix(AddMatrices(matrix1, matrix2));
        
        Console.WriteLine("Subtraction:");
        PrintMatrix(SubtractMatrices(matrix1, matrix2));
        
        Console.WriteLine("Multiplication:");
        PrintMatrix(MultiplyMatrices(matrix1, matrix2));
        
        Console.WriteLine("Transpose of Matrix 1:");
        PrintMatrix(TransposeMatrix(matrix1));
    }
}
