using System;
using System.Text.RegularExpressions;

class Program8{
    public static void Main(string[] args){
        string text= "here is an   example  with  useless spaces";
        string result = Regex.Replace(text, @"\s+", " ");
        Console.WriteLine(result);
    }
}
