using System;

class Program12{
    public static bool SearchMatrix(int[,] matrix, int target){
        int rows= matrix.GetLength(0), cols= matrix.GetLength(1);
        int left= 0, right= rows*cols-1;

        while (left <= right){
            int mid= left+(right-left)/2;
            int midValue= matrix[mid/cols, mid%cols];
            if(midValue == target)
                return true;
            else if(midValue < target)
                left= mid+1;
            else
                right= mid-1;
        }
        return false;
    }

    public static void Main(string[] args){
        int[,] matrix = {
            { 1, 3, 5 },
            { 7, 9, 11 },
            { 13, 15, 17 }
        };
        int target = 9;
        Console.WriteLine("Target Found " + SearchMatrix(matrix, target));
    }
}