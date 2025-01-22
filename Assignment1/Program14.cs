using System;

class Program14
{
    public static void Main(string[] args){
		
        double dis = double.Parse(Console.ReadLine());

        // Converting the distance to yards
        double distanceInYards = dis / 3;

        // Converting the distance to miles
        double distanceInMiles = distanceInYards / 1760;
		
		Console.WriteLine("Distance in feet " + dis + ", distance in yard " + distanceInYards + " and distance in miles " + distanceInMiles);
    }
}
