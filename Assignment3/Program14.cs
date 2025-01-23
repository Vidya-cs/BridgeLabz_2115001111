using System;

class Program14{
	public static void Main(String[] args){
	
		int num= int.Parse(Console.ReadLine());
		int p=1;
		
		//Finding factorial
		while(num!=0){
			p*=num;
			num--;
		}
		Console.WriteLine("Factorial is " + p);
	}
}