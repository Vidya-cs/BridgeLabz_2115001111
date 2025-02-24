using System;
using System.Text.RegularExpressions;

    class Program13{
        public static void Main(string[] args){
            string text = "The price is $45.99, and the discount is $ 10.50.";
            string pattern = @"\$?\s*\d+(\.\d{2})?"; 
            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine("Extracted currency values");
            for (int i = 0; i < matches.Count; i++){
                Console.WriteLine(matches[i].Value.Trim()); 
            }
        }
    }
}
