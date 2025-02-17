
using System;

class Program1{
    public static void Sort(int[] marks){
        int n= marks.Length;
        for(int i= 0; i<n-1; i++){
            for(int j= 0; j< n-i-1; j++){
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }
    }

    public static void Main(string[] args){
        int[] marks = { 85, 75, 95, 70, 90 };
        Sort(marks);
        Console.WriteLine("Sorted Marks:");
        foreach(int mark in marks)
            Console.Write(mark + " ");
    }
}



