using System;
using System.IO;

class Program1{
    public static void Main(string[] args){
        string filePath = "demo.txt";
        try{
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
	catch (FileNotFoundException){
            Console.WriteLine("File not found");
        }
    }
}
