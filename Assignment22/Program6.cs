
using System;

class ZeroSumSubarrays{
    int[] nums;

    public ZeroSumSubarrays(int[] arr){
        nums = arr;
    }

    public void FindZeroSumSubarrays()
    {
        for(int start= 0; start<nums.Length; start++){
            int sum = 0;
            for (int end = start; end < nums.Length; end++)
            {
                sum += nums[end];
                if (sum == 0)
                {
                    Console.WriteLine("Subarray Found: [" + start + " to " + end + "]");
                }
            }
        }
    }
}

class Program6{
    public static void Main(string[] args)
    {
        int[] arr = { 3, 4, -7, 1, 3, 3, 1, -4, -2, -2 };
        ZeroSumSubarrays zeroSum = new ZeroSumSubarrays(arr);

        Console.WriteLine("Zero Sum Subarrays:");
        zeroSum.FindZeroSumSubarrays();
    }
}



