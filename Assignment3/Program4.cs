using System;

class Program4{
	public static void Main(String[] args){
		int num= int.Parse(Console.ReadLine());
		
		//Checking whether it is natural number or not. If yes then print the sum of them
		
		if(num>=0){
			Console.WriteLine("The sum of " + num + " natural number is " + (num*(num+1))/2);
		}
		else{
			Console.WriteLine("The number " + num + " is not natural number");
		}
	}
}