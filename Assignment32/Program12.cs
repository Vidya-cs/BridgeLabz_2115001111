using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program12{
    static void Main(string[] args){
        var ids = new HashSet<string>();
        foreach (var line in File.ReadAllLines("students.csv").Skip(1)){
            var id = line.Split(',')[0];
            if (!ids.Add(id)) Console.WriteLine("Duplicate= " + line);
        }
    }
}
