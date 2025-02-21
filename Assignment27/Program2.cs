using System;
using System.Diagnostics;
using System.IO;

class Program2{
    static void CopyFile(string src, string dest, bool useBuffer){
        Stopwatch sw = new Stopwatch();
        sw.Start();
        using (FileStream fsIn = new FileStream(src, FileMode.Open, FileAccess.Read))
        using (FileStream fsOut = new FileStream(dest, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsIn = useBuffer ? new BufferedStream(fsIn, 4096) : fsIn)
        using (BufferedStream bsOut = useBuffer ? new BufferedStream(fsOut, 4096) : fsOut){
            byte[] buffer = new byte[4096];
            int bytesRead;
            while((bytesRead=bsIn.Read(buffer, 0, buffer.Length))>0){
                bsOut.Write(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        Console.WriteLine("Time Taken (" + (useBuffer ? "Buffered" : "Unbuffered") + "): " + sw.ElapsedMilliseconds + "ms");
    }

    static void Main(string[] args){
        string source = "datademo.txt";
        string dest1 = "unbuffered.txt";
        string dest2 = "buffered.txt";

        CopyFile(source, dest1, false); 
        CopyFile(source, dest2, true);  
    }
}
