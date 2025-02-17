using System;

class Program10{
    public static int FindPivot(int[] arr){
        int left= 0, right= arr.Length-1;
        while(left<right){
            int mid= left+(right-left)/2;
            if (arr[mid]>arr[right])
                left= mid+1;
            else
                right= mid;
        }
        return left; 
        }

    public static void Main(string[] args){
        int[] arr= {4, 5, 6, 7, 0, 1, 2};
        Console.WriteLine("Rotation Point " + FindPivot(arr));
    }
}



