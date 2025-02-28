using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program15{
    static void Main(string[] args){
        string encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes("Data"));
        File.WriteAllText("data.csv", encrypted);
        Console.WriteLine("Decrypted " + Encoding.UTF8.GetString(Convert.FromBase64String(encrypted)));
    }
}
