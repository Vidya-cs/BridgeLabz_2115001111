using System;
using System.Collections.Generic;

class Program9{
    static List<int> ConvertToSortedList(HashSet<int> set){
        List<int> list = new List<int>(set);
        for(int i= 0; i<list.Count-1; i++){
            for(int j= i+1; j<list.Count; j++){
                if(list[i]>list[j]){
                    int temp= list[i];
                    list[i]= list[j];
                    list[j]= temp;
                }
            }
        }
        return list;
    }

    public static void Main(string[] args){
        HashSet<int> set = new HashSet<int> {5, 3, 9, 1};
        List<int> sortedList = ConvertToSortedList(set);
        Console.Write("Sorted List: ");
        for(int i= 0; i<sortedList.Count; i++) 
			Console.Write(sortedList[i] + " ");
    }
}
