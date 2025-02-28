using System;
using System.IO;

class Program4{
    static void Main(string[] args){
        string filePath = "students.csv";
        if (File.Exists(filePath)){
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines){
                string[] data = line.Split(',');
                if (int.TryParse(data[3], out int marks) && marks>80){
                    Console.WriteLine(line);
                }
            }
        }
    }
}
