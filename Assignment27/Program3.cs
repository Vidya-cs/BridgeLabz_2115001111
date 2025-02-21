using System;
using System.IO;

class Program3{
    static void Main(string[] args){
        Console.Write("Enter your name ");
        string name = Console.ReadLine();

        Console.Write("Enter your age ");
        string age = Console.ReadLine();

        Console.Write("Enter your favorite game ");
        string language = Console.ReadLine();
        using (StreamWriter writer= new StreamWriter("userinfo.txt")){
            writer.WriteLine("Name " + name);
            writer.WriteLine("Age " + age);
            writer.WriteLine("Game " + language);
        }

        Console.WriteLine("User info saved");
    }
}
