using System;

class Program
{
    static int[] RotateList(int[] arr, int k)
    {
        int n = arr.Length;
        int[] rotated = new int[n];

        for (int i = 0; i < n; i++)
        {
            rotated[i] = arr[(i + k) % n]; // New index formula
        }
        return rotated;
    }

    public static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int rotateBy = 2;
        int[] rotatedArray = RotateList(numbers, rotateBy);

        Console.WriteLine("Rotated List:");
        for (int i = 0; i < rotatedArray.Length; i++)
        {
            Console.Write(rotatedArray[i] + " ");
        }
    }
}
