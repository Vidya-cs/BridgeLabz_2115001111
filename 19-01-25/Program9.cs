//Q9. Write a program that takes three numbers as input from the user and printstheir average

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the First number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2 + num3) / 3;

        Console.WriteLine("The average is: " + average);
    }
}