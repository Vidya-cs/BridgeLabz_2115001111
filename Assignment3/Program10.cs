using System;

class Program10{
	public static void Main(String[] args){
		
		double num= 10;
		double total= 0.0;
		
		//Displaying the sum
		
		while(num!=0){
			
			num= int.Parse(Console.ReadLine());
			total+= num;
		}
		Console.WriteLine(total);	
	}
}