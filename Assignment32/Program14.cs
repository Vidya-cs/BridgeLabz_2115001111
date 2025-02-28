using System;
using System.IO;
using System.Text.Json;

class Program14{
    static void Main(string[] args){
        string json = File.ReadAllText("students.json");
        var students = JsonSerializer.Deserialize<string[][]>(json);
        File.WriteAllLines("students.csv", students.Select(s => string.Join(",", s)));
    }
}
