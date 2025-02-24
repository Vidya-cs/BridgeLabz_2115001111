using System;
using System.Text.RegularExpressions;

class Program2{
    static bool IsValidPlate(string plate){
        string pattern = @"^[A-Z]{2}\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }

    public static void Main(string[] args){
        Console.Write("Enter a license plate ");
        string plate = Console.ReadLine();
        Console.WriteLine(IsValidPlate(plate) ? "Valid" : "Invalid");
    }
}
