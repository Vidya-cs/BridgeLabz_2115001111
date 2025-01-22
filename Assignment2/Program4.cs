using System;

class Program4
{
    public static void Main(string[] args){
		
        double celsius = double.Parse(Console.ReadLine());

        // Converting Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Displaying the result
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheit + " Fahrenheit");
    }
}
