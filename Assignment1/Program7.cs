using System;

class Program7
{
    public static void Main(String[] args)
    {
        // Read the radius of the earth as input from the user
        int radius = int.Parse(Console.ReadLine());
        
        // Calculate the volume of the earth in cubic kilometers using the formula (4/3)πr³
        double volumeEarth = ((double)4 / 3 * 3.14) * Math.Pow(radius, 3);
        
        // Display the volume of the earth in cubic kilometers and convert it to cubic miles
        // Conversion factor for cubic kilometers to cubic miles is (1.6³)
        Console.WriteLine("The volume of earth in cubic kilometers is " + volumeEarth + " and cubic miles " + volumeEarth * Math.Pow(1.6, 3));
    }
}
