using System;

class Program8{
	public static void Main(String[] args){
		int a= int.Parse(Console.ReadLine());
		int b= int.Parse(Console.ReadLine());
		int c= int.Parse(Console.ReadLine());
		
		//Performing Operations
		
		int res1= a + b * c;
		int res2= a * b + c;
		int res3= c + a / b;
		int res4= a % b + c;
		
		//Displaying the result
		
		Console.WriteLine("The result of Operations are " + res1 + ", " + res2 + ", " + res3 + ", " + res4);
	}
}