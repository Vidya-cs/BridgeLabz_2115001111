//Q6. Write a program to calculate simple interest using the formula: Simple Interest = (Principal * Rate * Time) / 100.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Principal amount:");
        double principal = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Rate of interest:");
        double rate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Time (in years):");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The Simple Interest is: " + simpleInterest);
    }
}