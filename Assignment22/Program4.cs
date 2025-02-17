using System;

class SlidingWindowMax{
    int[] nums;
    int k;

    public SlidingWindowMax(int[] arr, int windowSize)
    {
        nums = arr;
        k = windowSize;
    }

    public void FindMaxInWindows()
    {
        for (int i = 0; i <= nums.Length - k; i++)
        {
            int max = nums[i];
            for (int j = 1; j < k; j++)
            {
                if (nums[i + j] > max)
                {
                    max = nums[i + j];
                }
            }
            Console.Write(max + " ");
        }
        Console.WriteLine();
    }
}

class Program4
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        SlidingWindowMax windowMax = new SlidingWindowMax(arr, k);

        Console.WriteLine("Sliding Window Maximum:");
        windowMax.FindMaxInWindows();
    }
}