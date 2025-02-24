using System;
using System.Text.RegularExpressions;

class Program3{
    static bool IsValidHexColor(string color){
        string pattern = @"^#([A-Fa-f0-9]{6})$";
        return Regex.IsMatch(color, pattern);
    }

    public static void Main(string[] args){
        Console.Write("Enter a hex color code ");
        string color = Console.ReadLine();
        Console.WriteLine(IsValidHexColor(color) ? "Valid" : "Invalid");
    }
}
