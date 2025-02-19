using System;
using System.Collections.Generic;

class Program12{
    static List<string> GenerateBinaryNumbers(int n){
        Queue<string> queue = new Queue<string>();
        List<string> result = new List<string>();
        queue.Enqueue("1");

        for(int i= 0; i<n; i++){
            string current= queue.Dequeue();
            result.Add(current);
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
        return result;
    }

    public static void Main(string[] args){
        int n= 5;
        List<string> binaryNumbers = GenerateBinaryNumbers(n);

        Console.WriteLine("Binary numbers ");
        for(int i= 0; i<binaryNumbers.Count; i++){
            Console.Write(binaryNumbers[i] + " ");
        }
    }
}
