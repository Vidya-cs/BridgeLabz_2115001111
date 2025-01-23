using System;

class Program11{
	public static void Main(String[] args){
	
		double total= 0.0;
		
		//Displaying the sum
		
		while(true){
		
			double num= double.Parse(Console.ReadLine());
			if(num <=0){
				break;
			}
			total+= num;
			
		}
		Console.WriteLine(total);	
	}
}