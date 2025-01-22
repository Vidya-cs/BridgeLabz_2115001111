using System;

class Program12{
	public static void Main(String[] args){
		
		double pounds= double.Parse(Console.ReadLine());
		
		//Converting pounds to kg
		
		double kg= pounds * 2.2;
		
		//Displaying the result
		
		Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " + kg);
	}
}