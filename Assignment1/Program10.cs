using System;

class Program10
{
    public static void Main(string[] args)
    {
        
        // Taking user input
        double height = double.Parse(Console.ReadLine());

        // Convert height from centimeters to inches
        double totalInches = height / 2.54;

        // Convert inches to feet and calculate the remaining inches
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        // Display the result
        Console.WriteLine("Your Height in cm is " + height + " while in feet is " + feet + " and inches is " + inches);
    }
}
