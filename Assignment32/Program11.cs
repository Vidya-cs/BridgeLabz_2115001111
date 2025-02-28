using System;
using System.IO;

class Program11{
    static void Main(string[] args){
        using (var reader = new StreamReader("employees.csv")){
            int count = 0;
            while (!reader.EndOfStream){
                Console.WriteLine(reader.ReadLine());
                if (++count%100 == 0) 
					Console.WriteLine("Processed " + count + " lines");
            }
        }
    }
}
