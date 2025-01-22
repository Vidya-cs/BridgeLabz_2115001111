using System;

class Program1{
	public static void Main(String[] args){
		
		int num1= int.Parse(Console.ReadLine());
		int num2= int.Parse(Console.ReadLine());
		
		//Finding Remainder and Quotient
		
		int rem= num1%num2;
		int quot= num1/num2;
		
		//Displaying the result
		
		Console.WriteLine("The Quotient is " + quot + " and Remainder is " + rem + " of two numbers " + num1 + " and " + num2);
	}
}	