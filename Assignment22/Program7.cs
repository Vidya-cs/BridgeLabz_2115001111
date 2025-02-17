
using System;

class PairSum{
    int[] nums;
    int targetSum;

    public PairWithSum(int[] arr, int sum)
    {
        nums = arr;
        targetSum = sum;
    }

    public void FindPair()
    {
        for (int i = 0; i < nums.Length; i++){
            for (int j = i + 1; j < nums.Length; j++){
                if (nums[i] + nums[j] == targetSum)
                {
                    Console.WriteLine("Pair Found: " + nums[i] + ", " + nums[j]);
                    return;
                }
            }
        }
        Console.WriteLine("No Pair Found");
    }
}

class Program7{
    public static void Main(string[] args){
        int[] arr = { 1, 4, 45, 6, 10, 8 };
        int target = 16;
        PairSum pairSum = new PairSum(arr, target);

        Console.WriteLine("Checking for Pair:");
        pairSum.FindPair();
    }
}

