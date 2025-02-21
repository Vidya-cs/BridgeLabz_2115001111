using System;
using System.IO;

class Program1{
    static void Main(string[] args){
        string sourceFile = "data.txt";
        string destinationFile = "destination.txt";

        if (File.Exists(sourceFile)){
            using (FileStream fs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            using (FileStream fsOut = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fsOut)){
                string content = reader.ReadToEnd();
                writer.Write(content);
                Console.WriteLine("File copied successfully");
            }
        }
        else{
            Console.WriteLine("Source file does not exist");
        }
    }
}
