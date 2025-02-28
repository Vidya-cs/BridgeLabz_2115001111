using System;
using System.IO;

class Program5{
    static void Main(string[] args){
        string filePath = "employee.csv";
        Console.Write("Enter employee name ");
        string searchName = Console.ReadLine();
        if (File.Exists(filePath)){
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines){
                if (line.Contains(searchName)){
                    Console.WriteLine(line);
                }
            }
        }
    }
}
