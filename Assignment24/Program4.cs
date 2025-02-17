using System;
using System.IO;

class Program4{
    public static void ReadLines(string filePath){
        using(StreamReader reader= new StreamReader(filePath)){
            string line;
            while((line= reader.ReadLine())!= null){
                Console.WriteLine(line);
            }
        }
    }

    public static void Main(string[] args){
        string path = "Desktop/Program1.cs";
        ReadLines(path);
    }
}