using System;

class Program3{
	public static void Main(String[] args){
		double a= double.Parse(Console.ReadLine());
		double b= double.Parse(Console.ReadLine());
		double c= double.Parse(Console.ReadLine());
		
		//Performing Operations
		
		double res1= a + b * c;
		double res2= a * b + c;
		double res3= c + (double) a / b;
		double res4= a % b + c;
		
		//Displaying the result
		
		Console.WriteLine("The result of Operations are " + res1 + ", " + res2 + ", " + res3 + ", " + res4);
	}
}