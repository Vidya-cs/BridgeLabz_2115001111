using System;
using System.IO;

class Program7{
    public static void Main(string[] args){
        string filePath = "demo.txt";
            using(StreamWriter writer= new StreamWriter(filePath)){
                while(true){
                    string input= Console.ReadLine();
                    if(input.ToLower()=="exit")
                        break;
                    writer.WriteLine(input);
                }
            }

            Console.WriteLine("saved");
        }
    }
}