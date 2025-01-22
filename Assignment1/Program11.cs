using System;

class Program11
{
    public static void Main(string[] args){
		
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());

        // Performing arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
		double division=0.0;
		if(number2!=0){
			division= number1/number2;
		}
        
        // Display the results
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + number1 + " and " + number2 + " is " + addition + ", " + subtraction + ", " + multiplication + ", " + division);
	}
}
