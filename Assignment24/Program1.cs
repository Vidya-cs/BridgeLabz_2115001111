using System;
using System.Text;

class Program1{
    public static string Reverse(string input){
        StringBuilder sb = new StringBuilder();
        for(int i= input.Length-1; i>= 0; i--){
            sb.Append(input[i]);
        }
        return sb.ToString();
    }

    public static void Main(string[] args){
        Console.Write("Enter a string ");
        string input = Console.ReadLine();
        Console.WriteLine("Reversed string " + Reverse(input));
    }
}

