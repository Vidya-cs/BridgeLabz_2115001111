using System;
using System.Collections.Generic;

class Program7{
    static HashSet<int> GetUnion(HashSet<int> set1, HashSet<int> set2){
        HashSet<int> unionSet = new HashSet<int>(set1);
        List<int> list2 = new List<int>(set2);
        for(int i= 0; i<list2.Count; i++){
            unionSet.Add(list2[i]);
        }
        return unionSet;
    }

    static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2){
        HashSet<int> intersectionSet = new HashSet<int>();
        List<int> list1 = new List<int>(set1);
        for(int i= 0; i<list1.Count; i++){
            if(set2.Contains(list1[i])){
                intersectionSet.Add(list1[i]);
            }
        }
        return intersectionSet;
    }

    public static void Main(string[] args){
		
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
        HashSet<int> union = GetUnion(set1, set2);
        HashSet<int> intersection = GetIntersection(set1, set2);

        Console.Write("Union= ");
        List<int> unionList= new List<int>(union);
        for(int i= 0; i<unionList.Count; i++)
			Console.Write(unionList[i] + " ");

        Console.WriteLine("\nIntersection= ");
        List<int> intersectionList= new List<int>(intersection);
        for(int i= 0; i<intersectionList.Count; i++)
			Console.Write(intersectionList[i] + " ");
    }
}
