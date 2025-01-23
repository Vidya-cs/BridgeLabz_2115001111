using System;

class Program15{
	public static void Main(String[] args){
	
		int num= int.Parse(Console.ReadLine());
		int p=1;
		
		//Finding factorial
		for(int i=1; i<=num; i++){
			p*=i;
		}
		
		//Displaying Result
		
		Console.WriteLine("Factorial is " + p);
	}
}