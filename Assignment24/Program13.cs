using System;

class Program13{
    public static int FindFirst(int[] arr, int target){
        int left= 0, right= arr.Length-1, result= -1;
        while(left <= right){
            int mid= left+(right-left)/2;
            if(arr[mid] == target){
                result= mid;
                right= mid-1;
            }
            else if(arr[mid] < target)
                left= mid+1;
            else
                right= mid-1;
        }
        return result;
    }

    public static int FindLast(int[] arr, int target){
        int left= 0, right= arr.Length-1, result= -1;
        while(left <= right){
            int mid = left+(right-left)/2;
            if(arr[mid] == target){
                result= mid;
                left= mid+1;
            }
            else if(arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return result;
    }

    public static void Main(string[] args){
        int[] arr = { 1, 2, 3, 3, 3, 4, 5 };
        int target = 3;
        Console.WriteLine("First Occurrence= " + FindFirst(arr, target));
        Console.WriteLine("Last Occurrence= " + FindLast(arr, target));
    }
}



