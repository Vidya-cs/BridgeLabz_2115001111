using System;

class Program6{
	public static void Main(String[] args){
		
		int num= int.Parse(Console.ReadLine());
		
		//Checking the number is positive, zero or negative
		
		if(num>0){
			Console.WriteLine("Positive");
		}
		else if(num==0){
			Console.WriteLine("Zero");
		}
		else{
			Console.WriteLine("Negative");
		}
	}
}