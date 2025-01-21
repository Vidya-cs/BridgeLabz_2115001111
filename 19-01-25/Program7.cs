//Q7. Write a program to calculate the perimeter of a rectangle. Take the length and width as inputs and use the formula:

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the weight of the rectangle: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the rectangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (weight + height);

        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }
}