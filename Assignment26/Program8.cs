using System;
using System.Collections.Generic;

class Program8{
    static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2){
        HashSet<int> result = new HashSet<int>();
        List<int> list1 = new List<int>(set1);
        List<int> list2 = new List<int>(set2);
        for(int i= 0; i<list1.Count; i++){
            if(!set2.Contains(list1[i])) 
				result.Add(list1[i]);
        }

        for(int i= 0; i<list2.Count; i++){
            if(!set1.Contains(list2[i]))
				result.Add(list2[i]);
        }
        return result;
    }

    public static void Main(string[] args){
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
        HashSet<int> symmetricDiff = GetSymmetricDifference(set1, set2);
        Console.Write("Symmetric Difference ");
        List<int> resultList = new List<int>(symmetricDiff);
        for(int i= 0; i<resultList.Count; i++)
			Console.Write(resultList[i] + " ");
    }
}
