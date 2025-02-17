
using System;

class LongestConsecutive{
    int[] nums;

    public LongestConsecutive(int[] arr){
        nums = arr;
    }

    public int FindLongestSequence(){
        int longest = 0;
        for(int i= 0; i<nums.Length; i++){
            int num = nums[i];
            int count = 1;

            while (Array.Exists(nums, e => e == num + 1)){
                num++;
                count++;
            }

            longest = Math.Max(longest, count);
        }
        return longest;
    }
}

class Program8{
    public static void Main(string[] args){
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        LongestConsecutive longestSeq = new LongestConsecutive(arr);

        Console.WriteLine("Longest Consecutive Sequence: " + longestSeq.FindLongestSequence());
    }
}



