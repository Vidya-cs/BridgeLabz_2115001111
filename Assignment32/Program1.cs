using System;
using System.IO;

class Program1{
    public static void Main(string[] args){
        string filePath = "students.csv";
        if (File.Exists(filePath)){
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines){
                Console.WriteLine(line);
            }
        }
        else{
            Console.WriteLine("File not found");
        }
    }
}
