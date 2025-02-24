using System;
using System.Text.RegularExpressions;


class Program5{
    public static void Main(string[] args){
        string text = "My name is Vidya Sagar and I am here to Learn C#";
        string pattern = @"\b[A-Z][a-z]*\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches){
            Console.Write(match.Value + " ");
        }
    }
}
