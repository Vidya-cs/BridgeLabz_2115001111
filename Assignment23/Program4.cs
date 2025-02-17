
using System;

class Program4{
    public static void Sort(int[] prices, int left, int right){
        if(left<right){
            int pivot= Partition(prices, left, right);
            Sort(prices, left, pivot - 1);
            Sort(prices, pivot + 1, right);
        }
    }

    public static int Partition(int[] prices, int left, int right){
        int pivot = prices[right], i = left - 1;
        for (int j = left; j < right; j++){
            if(prices[j]<pivot){
                i++;
                (prices[i], prices[j]) = (prices[j], prices[i]);
            }
        }
        (prices[i + 1], prices[right]) = (prices[right], prices[i + 1]);
        return i+1;
    }

    public static void Main(string[] args){
        int[] prices= {500, 300, 100, 400, 200};
        Sort(prices, 0, prices.Length - 1);
        Console.WriteLine("Sorted product price");
        foreach(int price in prices)
            Console.Write(price + " ");
    }
}



