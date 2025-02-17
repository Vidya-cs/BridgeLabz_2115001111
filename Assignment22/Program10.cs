using System;

class TwoSumProblem
{
    private int[] nums;
    private int target;

    public TwoSumProblem(int[] arr, int sum)
    {
        nums = arr;
        target = sum;
    }

    public void FindTwoSum()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    Console.WriteLine("Two Sum Indices: " + i + ", " + j);
                    return;
                }
            }
        }
        Console.WriteLine("No Two Sum Pair Found");
    }
}

class Program10{
    public static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;
        TwoSumProblem twoSum = new TwoSumProblem(arr, target);

        Console.WriteLine("Checking for Two Sum:");
        twoSum.FindTwoSum();
    }
}
