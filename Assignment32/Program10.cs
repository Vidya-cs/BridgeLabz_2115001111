using System;
using System.IO;
using System.Linq;

class Program10{
    static void Main(string[] args){
        var dict = File.ReadAllLines("students.csv").Skip(1).ToDictionary(l => l.Split(',')[0], l => l);
        foreach (var line in File.ReadAllLines("students1.csv").Skip(1)){
            var id = line.Split(',')[0];
            if (dict.ContainsKey(id))
                Console.WriteLine(dict[id] + "," + line);
        }
    }
}
