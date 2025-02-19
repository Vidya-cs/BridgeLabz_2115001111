using System;
using System.Collections.Generic;

class Program6{
    static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2){
        if(set1.Count!=set2.Count) 
			return false;
        List<int> list1 = new List<int>(set1);
        List<int> list2 = new List<int>(set2);
        for(int i= 0; i<list1.Count; i++){
            if(!set2.Contains(list1[i]))
				return false;
        }
        return true;
    }

    public static void Main(string[] args){
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };
        bool result = AreSetsEqual(set1, set2);
        Console.WriteLine(result);
    }
}
