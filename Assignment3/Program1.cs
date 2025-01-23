using System;

class Program1{
	public static void Main(String[] args){
		int x= int.Parse(Console.ReadLine());
		
		//Checking divisibility and displaying the result
		
		if(x%5!=0){
			Console.WriteLine("No the number is not divisible by 5");
		}
		else{
			Console.WriteLine("Yes the number is divisible by 5");
		}
	}
}