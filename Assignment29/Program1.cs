using System;
using System.Text.RegularExpressions;

class Program1{
    static bool IsValidUsername(string username){
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        return Regex.IsMatch(username, pattern);
    }

    public static void Main(string[] args){
        Console.Write("Enter username ");
        string username = Console.ReadLine();
        Console.WriteLine(IsValidUsername(username) ? "Valid" : "Invalid");
    }
}
