
using System;

class Program14{
    public static int FindMissingPositive(int[] nums){
        int n = nums.Length;
        for(int i= 0; i<n-1; i++){
           for(int j= 0; j<n-1-i; j++){
              if(nums[j]>nums[j+1]){
                 int temp= nums[j];
                 nums[j]= nums[j+1];
                 nums[j+1]= temp;
              }
           }
       }
        int expected= 1;
        foreach(int num in nums){
            if(num == expected) 
               expected++;
        }
        return expected;
    }

    public static int BinarySearch(int[] nums, int target){
        int left= 0, right= nums.Length-1;
        while(left <= right){
            int mid = left+(right-left)/2;
            if(nums[mid] == target)
                return mid;
            else if(nums[mid] < target)
                left= mid+1;
            else
                right= mid-1;
        }
        return -1;
    }

    public static void Main(string[] args){
        int[] nums = {3, 4, -1, 1};
        Console.WriteLine("First missing positive number " + FindMissingPositive(nums));
        int[] sortedArr = {1, 2, 3, 4, 5};
        int target = 3;
        Console.WriteLine("Binary search index " + BinarySearch(sortedArr, target));
    }
}



