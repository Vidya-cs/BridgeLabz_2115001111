using System;
using System.Text.RegularExpressions;

    class Program15{
        public static void Main(string[] args){
            Console.WriteLine("Enter an SSN ");
            string ssn = Console.ReadLine();
            string pattern = @"^\d{3}-\d{2}-\d{4}$"; 
            Console.WriteLine(Regex.IsMatch(ssn, pattern) ? "Valid SSN" : "Invalid SSN");
        }
    }
