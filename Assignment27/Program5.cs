using System;
using System.IO;

class Program5{
    static void Main(string[] args){
        string inputFile = "file.jpg";
        string outputFile = "output.jpg";

        byte[] imageData = File.ReadAllBytes(inputFile);
        File.WriteAllBytes(outputFile, imageData);
        Console.WriteLine("Image copied successfully");
    }
}
