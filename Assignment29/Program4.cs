using System;
using System.Text.RegularExpressions;

class Program4{
    static void Main(string[] args){
        string text = "Contact us at example@example.com and vidya@gmail.com";
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches){
            Console.WriteLine(match.Value);
        }
    }
}
