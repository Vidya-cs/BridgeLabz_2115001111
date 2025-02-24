using System;
using System.Text.RegularExpressions;

    class Program14{
        public static void Main(string[] args){
            string text = "This is is a repeated repeated word test.";
            string pattern = @"\b(\w+)\s+\1\b"; 
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            Console.WriteLine("Repeating Words");
           
            for (int i = 0; i < matches.Count; i++){
                Console.WriteLine(matches[i].Groups[1].Value);
            }
        }
    }
