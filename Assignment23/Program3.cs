
using System;

class Program3{
    public static void Sort(int[] prices, int left, int right){
        if(left<right){
            int mid= (left+right)/2;
            Sort(prices, left, mid);
            Sort(prices, mid + 1, right);
            Merge(prices, left, mid, right);
        }
    }

    public static void Merge(int[] prices, int left, int mid, int right){
        int n1= mid-left+1;
        int n2= right-mid;
        int[] leftArr= new int[n1], rightArr= new int[n2];

        for (int i = 0; i < n1; i++){ 
             leftArr[i] = prices[left + i];
         }
        for(int j = 0; j < n2; j++){
             rightArr[j] = prices[mid + 1 + j];
         }
        int i1= 0, i2= 0, k= left;
        while(i1<n1 && i2<n2){
            if(leftArr[i1] <= rightArr[i2]) 
                prices[k++] = leftArr[i1++];
            else 
                prices[k++] = rightArr[i2++];
        }

        while(i1<n1){
             prices[k++] = leftArr[i1++];
        }
        while(i2<n2){
           prices[k++] = rightArr[i2++];
        }
    }

    public static void Main(string[] args){
        int[] prices= {300, 100, 200, 400, 150};
        Sort(prices, 0, prices.Length-1);
        Console.WriteLine("Sorted Book price");
        foreach(int price in prices)
            Console.Write(price + " ");
    }
}





