
using System;

class Program7{
    public static void Sort(int[] ages){
        int[] count= new int[19];
        foreach(int age in ages)
            count[age]++;

        int index = 0;
        for(int i= 10; i<=18; i++){
            while (count[i]>0){
                ages[index++]= i;
                count[i]--;
            }
        }
    }

    public static void Main(string[] args){
        int[] ages= {12, 15, 11, 18, 13, 14, 12};
        Sort(ages);
        Console.WriteLine("Sorted students age");
        foreach(int age in ages)
            Console.Write(age + " ");
    }
}



