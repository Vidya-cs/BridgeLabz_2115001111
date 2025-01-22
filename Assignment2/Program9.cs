using System;

class Program9
{
    public static void Main(string[] args){
		
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        //Calculating the perimeter of the park
        double perimeter = side1 + side2 + side3;

        //Converting distance from kilometers to meters
        double distanceToRun = 5000;

        //Calculating the total number of rounds
        double rounds = Math.Ceiling(distanceToRun / perimeter);

        //Displaying the result
        Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km.");
    }
}
