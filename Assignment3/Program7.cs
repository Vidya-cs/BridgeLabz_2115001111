using System;

class Program7{
	public static void Main(String[] args){
		
		int month= int.Parse(Console.ReadLine());
		int day= int.Parse(Console.ReadLine());
		
		//Checking its Spring Season or not
		
		if( (month == 5 && day>=20) || (month == 6 && day <=20)){
			Console.WriteLine("Its Spring Season");
		}
		else{
			Console.WriteLine("Its not a Spring Season");
		}
	}
}