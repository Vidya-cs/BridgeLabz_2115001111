using System;
using System.Collections.Generic;

class Program14{
    static Dictionary<string, int> CountWordFrequency(string text){
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string[] words = text.ToLower().Split(new char[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
        for(int i= 0; i<words.Length; i++){
            if(wordCount.ContainsKey(words[i])){
                wordCount[words[i]]++;
            }
            else{
                wordCount[words[i]] = 1;
            }
        }
        return wordCount;
    }

    public static void Main(string[] args){
        string text = "Hello world, Hello Hindustaan";
        Dictionary<string, int> result= CountWordFrequency(text);
        Console.WriteLine("Word frequency");
        List<string> keys = new List<string>(result.Keys);
        for(int i= 0; i<keys.Count; i++){
            Console.WriteLine(keys[i] + ": " + result[keys[i]]);
        }
    }
}
