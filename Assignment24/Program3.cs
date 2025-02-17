using System;
using System.Text;

class Program3{
    public static string Concatenate(string[] words){
        StringBuilder sb = new StringBuilder();
        for(int i= 0; i<words.Length; i++){
            sb.Append(words[i]);
            sb.Append(" ");
        }
        return sb.ToString().Trim();
    }

    public static void Main(string[] args){
        string[] words = { "Hello", "Vidya", "is", "here" };
        Console.WriteLine("Concatenated String " + Concatenate(words));
    }
}



