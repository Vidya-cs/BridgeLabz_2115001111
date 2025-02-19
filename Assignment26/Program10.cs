using System;
using System.Collections.Generic;

class Program10{
    static bool IsSubset(HashSet<int> subset, HashSet<int> mainSet){
        List<int> subsetList = new List<int>(subset);
        for(int i= 0; i<subsetList.Count; i++){
            if(!mainSet.Contains(subsetList[i]))
				return false;
        }
        return true;
    }

    public static void Main(string[] args){
        HashSet<int> subset = new HashSet<int> { 2, 3 };
        HashSet<int> mainSet = new HashSet<int> { 1, 2, 3, 4 };
        bool result = IsSubset(subset, mainSet);
        Console.WriteLine("It is subset or not= " + result);
    }
}
