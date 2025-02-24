using System;
using System.Text.RegularExpressions;

class Program12{
    public static void Main(string[] args){
        string text = "I have learnt Java, Javascript, C# and Python";
        string pattern = @"\b(Java|Python|JavaScript|C#)\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches){
            Console.WriteLine(match.Value);
        }
    }
}
