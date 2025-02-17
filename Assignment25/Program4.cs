using System;
using System.IO;
using System.Diagnostics;

class Program4{
    public static void ReadUsingStreamReader(string filePath){
        using (StreamReader sr = new StreamReader(filePath)){
            while(sr.ReadLine()!=null){}
        }
    }

    public static void ReadUsingFileStream(string filePath){
        using (FileStream fs = new FileStream(filePath, FileMode.Open)){
            byte[] buffer= new byte[1024];
            while(fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }

    public static void Main(string[] args){
        string filePath = "Desktop/demo.txt";
        Stopwatch sw = Stopwatch.StartNew();
        ReadUsingStreamReader(filePath);
        sw.Stop();
        Console.WriteLine("Streamreader time " + sw.ElapsedMilliseconds);
        sw = Stopwatch.StartNew();
        ReadUsingFileStream(filePath);
        sw.Stop();
        Console.WriteLine("Filestream time " + sw.ElapsedMilliseconds);
    }
}