using System;

class Program12
{
    public static void Main(string[] args)
    {
        double baseLength = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        // Calculate the area of the triangle in square centimeters
        double areaInCm = 0.5 * baseLength * height;

        // Convert the area to square inches
        double areaInInches = areaInCm / 6.4516;

        // Display the results
        Console.WriteLine("The area of the triangle in cm is "+ areaInCm + " and in inches is " + areaInInches);
    }
}
