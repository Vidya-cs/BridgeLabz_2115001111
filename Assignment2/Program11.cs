using System;

class Program11{
	public static void Main(String[] args){
		
		double principal= double.Parse(Console.ReadLine());
		double rate= double.Parse(Console.ReadLine());
		double time= double.Parse(Console.ReadLine());
		
		//Calculating SI
		
		double si= (double)(principal*rate*time)/100;
		
		//Displaying Result
		
		Console.WriteLine("The Simple Interest is " + si);
	}
}