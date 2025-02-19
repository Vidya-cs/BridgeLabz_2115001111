using System;
using System.Collections;
using System.Collections.Generic;

class Program1{

	//ArrayList
    static ArrayList ReverseArrayList(ArrayList list){
        ArrayList reversedList = new ArrayList();
        for(int i= list.Count-1; i>=0; i--){
            reversedList.Add(list[i]);
        }
        return reversedList;
    }

	//Linked List
    static LinkedList<int> ReverseLinkedList(LinkedList<int> list){
        LinkedList<int> reversedList = new LinkedList<int>();
        LinkedListNode<int> current = list.Last; 
        while(current!=null){
            reversedList.AddLast(current.Value);
            current = current.Previous;
        }
        return reversedList;
    }

    public static void Main(string[] args){
        
        ArrayList numbersArrayList = new ArrayList() { 1, 2, 3, 4, 5 };

        ArrayList reversedArrayList = ReverseArrayList(numbersArrayList);
        Console.WriteLine("Reversed ArrayList ");
        for(int i= 0; i<reversedArrayList.Count; i++){
            Console.Write(reversedArrayList[i] + " ");
        }

        LinkedList<int> numbersLinkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
		
        LinkedList<int> reversedLinkedList = ReverseLinkedList(numbersLinkedList);
        Console.WriteLine("Reversed LinkedList: ");
        LinkedListNode<int> node = reversedLinkedList.First;
        for(int i= 0; i<reversedLinkedList.Count; i++){
            Console.Write(node.Value + " ");
            node = node.Next;
        }
    }
}
