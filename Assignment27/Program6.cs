using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program6{
    static void Main(string[] args){
        string filename = "datafile.txt";
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        using (StreamReader reader = new StreamReader(filename)){
            string line;
            while((line = reader.ReadLine())!=null){
                string[] words = line.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words){
                    string cleanWord = word.Trim(new char[] { '.', ',', '!', '?' });
                    if (wordCounts.ContainsKey(cleanWord))
                        wordCounts[cleanWord]++;
                    else
                        wordCounts[cleanWord] = 1;
                }
            }
        }

        var top5Words = wordCounts.OrderByDescending(kvp => kvp.Value).Take(5);
        foreach (var word in top5Words){
            Console.WriteLine(word.Key + " - " + word.Value);
        }
    }
}
