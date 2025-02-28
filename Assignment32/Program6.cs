using System;
using System.IO;

class Program6{
    static void Main(string[] args){
        string filePath = "employee.csv";
        string[] lines = File.ReadAllLines(filePath);
        for(int i= 1; i<lines.Length; i++){
            string[] data = lines[i].Split(',');
            if (data[2] == "IT"){
                data[3] = (int.Parse(data[3]) * 1.1).ToString();
                lines[i] = string.Join(",", data);
            }
        }
        File.WriteAllLines("updated.csv", lines);
        Console.WriteLine("Salaries updated");
    }
}
