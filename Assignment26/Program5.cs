using System;
using System.Collections.Generic;

class Program5{
    static string FindNthFromEnd(LinkedList<string> list, int n){
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;
        for(int i= 0; i<n; i++){
            if(second==null) 
				return "n is larger than list size given";
            second = second.Next;
        }

        while(second != null){
            first = first.Next;
            second = second.Next;
        }
        return first.Value;
    }

    public static void Main(string[] args){
        LinkedList<string> linkedList = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        int N = 2;
        string result = FindNthFromEnd(linkedList, N);
        Console.WriteLine("Nth element from end is " + result);
    }
}
