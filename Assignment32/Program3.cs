using System;
using System.IO;

class Program3{
    public static void Main(string[] args){
        string filePath = "students.csv";
        if (File.Exists(filePath)){
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Total records " + (lines.Length-1)); 
        }
        else{
            Console.WriteLine("File not found");
        }
    }
}
