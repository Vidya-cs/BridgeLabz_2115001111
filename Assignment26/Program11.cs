using System;
using System.Collections.Generic;

class Program11{
    static Queue<int> ReverseQueue(Queue<int> queue){
        Stack<int> stack = new Stack<int>();
        int size= queue.Count;
        int[] tempArray= new int[size];
        for(int i= 0; i<size; i++){
            tempArray[i]= queue.Dequeue();
        }

        for(int i= 0; i<size; i++){
            stack.Push(tempArray[i]); 
        }

        for(int i= 0; i<size; i++){
            queue.Enqueue(stack.Pop()); 
        }
        return queue;
    }

    public static void Main(string[] args){
        Queue<int> numbers = new Queue<int>();
        numbers.Enqueue(10);
        numbers.Enqueue(20);
        numbers.Enqueue(30);

        Console.WriteLine("Original queue= ");
        int size = numbers.Count;
        int[] temp = new int[size];
        for(int i= 0; i<size; i++){
            temp[i]= numbers.Dequeue();
            Console.Write(temp[i] + " ");
            numbers.Enqueue(temp[i]);
        }
        numbers = ReverseQueue(numbers);
        Console.WriteLine("\nReversed Queue= ");
        size = numbers.Count;
        for(int i= 0; i<size; i++){
            temp[i] = numbers.Dequeue();
            Console.Write(temp[i] + " ");
            numbers.Enqueue(temp[i]); 
        }
    }
}
