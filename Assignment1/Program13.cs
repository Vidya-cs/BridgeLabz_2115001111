using System;

class Program13
{
    public static void Main(string[] args)
    {
        double perimeter = double.Parse(Console.ReadLine());

        // Calculatingthe side of the square
        double side = perimeter / 4;

        // Displaying the result
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
