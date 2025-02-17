
using System;

class StockSpan{
    int[] prices = new int[100];
    int[] span = new int[100];
    int top = -1;
    public void AddPrice(int price){
        prices[++top] = price;
    }

    public void CalculateSpan(){
        for(int i = 0; i <= top; i++){
            span[i] = 1;
            for(int j = i - 1; j >= 0 && prices[j] <= prices[i]; j--){
                span[i]++;
            }
        }
    }

    public void DisplaySpan(){
        for(int i=0; i<=top; i++)
            Console.Write(span[i] + " ");
        Console.WriteLine();
    }
}

class Program3{
    public static void Main(string[] args)
    {
        StockSpan stock = new StockSpan();
        stock.AddPrice(100);
        stock.AddPrice(80);
        stock.AddPrice(60);
        stock.AddPrice(70);
        stock.AddPrice(60);
        stock.AddPrice(75);
        stock.CalculateSpan();
        Console.WriteLine("Span");
        stock.DisplaySpan();
    }
}



