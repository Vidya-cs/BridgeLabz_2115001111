using System;
using System.Text;

class Program2{
    public static string Remove(string input){
        StringBuilder sb = new StringBuilder();
        bool[] flag = new bool[256];

        foreach(char c in input){
            if(!flag[c]){
                sb.Append(c);
                flag[c] = true;
            }
        }
        return sb.ToString();
    }

    public static void Main(string[] args){
        Console.Write("Enter a string ");
        string input= Console.ReadLine();
        Console.WriteLine("String without duplicates " + Remove(input));
    }
}



