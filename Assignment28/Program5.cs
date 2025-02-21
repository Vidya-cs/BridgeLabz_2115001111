using System;
using System.IO;

class Program5{
    public static void Main(string[] args){
        string filePath = "data.txt";

        try{
            using (StreamReader reader = new StreamReader(filePath)){
                Console.WriteLine("First line " + reader.ReadLine());
            }
        }
        catch (IOException){
            Console.WriteLine("Error reading file");
        }
    }
}
