using System;

class Program17{
	public static void Main(String[] args){
		
		int year= int.Parse(Console.ReadLine());
		double salary= double.Parse(Console.ReadLine());
		double bonus;
	
		//Checking whether year served is more than 5
		
		if(2025-year > 5){
			bonus= salary * .05;
		}
		else{
			bonus= 0;
		}
		
		//Displaying the Bonus amount
		
		Console.WriteLine("Bonus Amount is " + bonus);
	}
}