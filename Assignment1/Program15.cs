using System;

class Program15{
	public static void Main(String[] args){
		double unitPrice= double.Parse(Console.ReadLine());
		int quantity= int.Parse(Console.ReadLine());
		
		//Calculating total cost 
		double totalCost= unitPrice * quantity;
		
		//Displaying the result
		
		Console.WriteLine("The total purchase price is INR " + totalCost + " if the quantity is " + quantity + " and unit price is INR " + unitPrice);
	}
}