using System;
using System.Text;
using System.Diagnostics;

class Program3{
    public static void Main(String[] args){
        int repeatCount= 100000;
        string text= "Hello";
        Stopwatch sw = Stopwatch.StartNew();
        string result = "";
        for(int i= 0; i<repeatCount; i++){
            result += text;
        }
        sw.Stop();
        Console.WriteLine("String time= " + sw.ElapsedMilliseconds);

        sw = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for(int i= 0; i<repeatCount; i++){
           sb.Append(text);
        }
        sw.Stop();
        Console.WriteLine("StringBuilder time= " + sw.ElapsedMilliseconds);
    }
}



