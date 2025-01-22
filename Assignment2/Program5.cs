using System;

class Program5
{
    public static void Main(string[] args){
		
        double fahrenheit = double.Parse(Console.ReadLine());

        // Converting Fahrenheit to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Displaying the result
        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius");
    }
}
