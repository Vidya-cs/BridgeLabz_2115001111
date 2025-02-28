using System;
using System.IO;
using System.Linq;

class Program{
    public static void Main(string[] args){
        string filePath = "employees.csv";
        var sorted = File.ReadAllLines(filePath).Skip(1).OrderByDescending(line => int.Parse(line.Split(',')[3]));
        Console.WriteLine(string.Join("\n", sorted.Take(5)));
    }
}
