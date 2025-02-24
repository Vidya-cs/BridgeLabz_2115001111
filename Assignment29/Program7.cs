using System;
using System.Text.RegularExpressions;

class Program7{
    public static void Main(string[] args){
        string text = "https://www.google.com and http://wiki.com are most informative";
        string pattern = @"https?://\S+";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches){
            Console.WriteLine(match.Value);
        }
    }
}
