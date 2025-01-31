using System;

class Program8{
	
    public static double FahrenheitToCelsius(double f){
        return (f-32)*5/9;
    }

    public static double CelsiusToFahrenheit(double c){
        return (c*9/5)+32;
    }

    public static void Main(String[] args){
		
        Console.WriteLine("Enter temperature");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Want to convert in C or F");
        char choice = Convert.ToChar(Console.ReadLine());

        if(choice=='C' || choice=='c'){
            double celsius= FahrenheitToCelsius(temp);
            Console.WriteLine("Temperature in Celsius " + celsius);
        }
        else if(choice=='F' || choice=='f'){
            double fahrenheit = CelsiusToFahrenheit(temp);
            Console.WriteLine("Temperature in Fahrenheit " + fahrenheit);
        }
        else{
            Console.WriteLine("Pls Choose between F or C");
        }
    }
}
