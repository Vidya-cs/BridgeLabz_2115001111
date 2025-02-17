using System;

class Program5{
    public static void Sort(int[] scores){
        int n= scores.Length;
        for(int i= 0; i<n-1; i++){
            int minIndex = i;
            for(int j= i+1; j<n; j++){
                if(scores[j]<scores[minIndex])
                    minIndex= j;
            }
            (scores[i], scores[minIndex]) = (scores[minIndex], scores[i]);
        }
    }

    public static void Main(string[] args){
        int[] scores= {50, 40, 30, 60, 20};
        Sort(scores);
        Console.WriteLine("Sorted exam score");
        foreach(int score in scores)
            Console.Write(score + " ");
    }
}