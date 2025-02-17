using System;
using System.IO;

class Program5{
    public static int CountOccurrences(string filePath, string word){
        int count= 0;
        using(StreamReader reader=new StreamReader(filePath)){
            string line;
            while((line=reader.ReadLine())!= null){
                string[] words= line.Split(' ');
                foreach(string w in words){
                    if(w.Equals(word, StringComparison.OrdinalIgnoreCase))
                        count++;
                }
            }
        }
        return count;
    }

    public static void Main(string[] args){
        string path = "Desktop/Program1.cs";
        Console.Write("Enter word to count ");
        string word = Console.ReadLine();
        Console.WriteLine("Occurrences are " + CountOccurrences(path, word));
    }
}