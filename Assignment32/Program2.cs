using System;
using System.IO;

class Program2{
    public static void Main(string[] args){
        string filePath = "employees.csv";
        string[] employees ={
            "ID,Name,Department,Salary",
            "1,John,IT,50000",
            "2,Emma,HR,45000",
            "3,David,Finance,55000",
            "4,Sophia,IT,60000",
            "5,James,Marketing,48000"
        };

        File.WriteAllLines(filePath, employees);
        Console.WriteLine("CSV file created");
    }
}
