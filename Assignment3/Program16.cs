using System;

class Program16{
	public static void Main(String[] args){
	
		int num= int.Parse(Console.ReadLine());
		
		//Checking and Displaying whether the number is odd or even
		for(int i=1; i<=num; i++){
			if(i%2==0){
				Console.WriteLine(i + " Is Even");
			}
			else{
				Console.WriteLine(i + " Is Odd");
			}
		}
	}
}