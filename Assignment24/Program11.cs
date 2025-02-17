using System;

class Program11{
    public static int FindPeak(int[] arr){
        int left= 0, right= arr.Length-1;
        while(left<right){
            int mid= left+(right-left)/2;
            if(arr[mid]>arr[mid+1])
                right= mid;
            else
                left= mid+1;
        }
        return left; 
    }

    public static void Main(string[] args){
        int[] arr = {1, 2, 3, 1};
        Console.WriteLine("Peak Element =" + FindPeak(arr));
    }
}