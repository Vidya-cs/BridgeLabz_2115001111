using System;
using System.Collections.Generic;

class Program15{
    static Dictionary<int, List<string>> InvertDictionary(Dictionary<string, int> inputDict){
        Dictionary<int, List<string>> invertedDict = new Dictionary<int, List<string>>();
        List<string> keys = new List<string>(inputDict.Keys);
        for(int i= 0; i<keys.Count; i++){
            string key = keys[i];
            int value = inputDict[key];

            if(!invertedDict.ContainsKey(value)){
                invertedDict[value] = new List<string>();
            }
            invertedDict[value].Add(key);
        }
        return invertedDict;
    }

    public static void Main(string[] args){
        Dictionary<string, int> input = new Dictionary<string, int>{
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };
        Dictionary<int, List<string>> output = InvertDictionary(input);
        Console.WriteLine("Inverted dictionary");
        List<int> keys = new List<int>(output.Keys);
        for(int i= 0; i<keys.Count; i++){
            Console.Write(keys[i] + " = [");
            List<string> values = output[keys[i]];
            for(int j= 0; j<values.Count; j++){
                Console.Write(values[j]);
                if(j<values.Count-1) 
					Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}
