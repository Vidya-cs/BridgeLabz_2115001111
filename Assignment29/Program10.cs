using System;
using System.Text.RegularExpressions;

class Program10{
    static bool IsValidIP(string ip){
        string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
        return Regex.IsMatch(ip, pattern);
    }

    public static void Main(string[] args){
        Console.Write("Enter an IP Address ");
        string ip = Console.ReadLine();
        Console.WriteLine(IsValidIP(ip) ? "Valid" : "Invalid");
    }
}
