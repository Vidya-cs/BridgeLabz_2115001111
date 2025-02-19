using System;
using System.Collections.Generic;

class Program4{
    static List<int> RemoveDuplicates(int[] arr){
        List<int> uniqueList = new List<int>();
        HashSet<int> seen = new HashSet<int>();
        for(int i= 0; i<arr.Length; i++){
            if(!seen.Contains(arr[i])){
                uniqueList.Add(arr[i]);
                seen.Add(arr[i]);
            }
        }
        return uniqueList;
    }

    public static void Main(string[] args){
        int[] numbers = {3, 1, 2, 2, 3, 4};
        List<int> result = RemoveDuplicates(numbers);
        Console.WriteLine("List after removing duplicates ");
        for(int i= 0; i<result.Count; i++){
            Console.Write(result[i] + " ");
        }
    }
}
