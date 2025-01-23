using System;

class Program2{
	public static void Main(String[] args){
		int num1= int.Parse(Console.ReadLine());
		int num2= int.Parse(Console.ReadLine());
		int num3= int.Parse(Console.ReadLine());
		
		if(num1 < num2 && num1 < num3){
			Console.WriteLine("Yes, num1 is the smallest");
		}
		else{
			Console.WriteLine("No, num1 is not smallest");
		}
	}
}