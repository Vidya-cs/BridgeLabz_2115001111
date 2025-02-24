using System;
using System.Text.RegularExpressions;

class Program9{
    public static void Main(string[] args){
        string text = "This is a damn bad example with some stupid words.";
        string[] badWords = {"damn", "stupid"};
        foreach (string word in badWords){
            text = Regex.Replace(text, word, "****", RegexOptions.IgnoreCase);
        }
        Console.WriteLine(text);
    }
}
