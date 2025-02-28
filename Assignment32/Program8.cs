using System;
using System.IO;
using System.Text.RegularExpressions;

class Program8{
    static void Main(string[] args){
        string filePath = "contacts.csv";
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";
        foreach (string line in File.ReadAllLines(filePath)){
            string[] data = line.Split(',');
            if (!Regex.IsMatch(data[1], emailPattern) || !Regex.IsMatch(data[2], phonePattern)){
                Console.WriteLine("Invalid record " + line);
            }
        }
    }
}
