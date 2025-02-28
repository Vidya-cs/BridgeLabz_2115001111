using System;
using System.IO;

class Program113{
    static void Main(string[] args){
        string[] records = {"ID,Name,Department,Salary", "101,Vidya Sagar,IT,60000", "102,Sanskar,HR,50000"};
        File.WriteAllLines("employees.csv", records);
    }
}
