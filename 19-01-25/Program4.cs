//Q4. Write a program to calculate the area of circle. Take the radius as input and use the formula:

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("The area of the circle is: " + area);
    }
}