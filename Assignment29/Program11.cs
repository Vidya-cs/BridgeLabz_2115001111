using System;
using System.Text.RegularExpressions;

class Program11{
    static bool IsValidCard(string card){
        string pattern = @"^(4|5)\d{15}$";
        return Regex.IsMatch(card, pattern);
    }

    public static void Main(string[] args){
        Console.Write("Enter a credit card number ");
        string card = Console.ReadLine();
        Console.WriteLine(IsValidCard(card) ? "Valid" : "Invalid");
    }
}
