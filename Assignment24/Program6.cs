using System;
using System.IO;
using System.Text;

class Program6{
    public static void Main(string[] args){
        string filePath = "binarydata.dat";
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("File content as characters:" + content);
            }
    }
}



